// Import required libraries
const express = require("express");
const path = require("path");
const bodyParser = require("body-parser")
const mysql = require("mysql")

// Set up Express.js
const app = express();

// Initialize server variables
const port = 8000;
var server = null;
var con = mysql.createConnection({
    host: "localhost",
    user: "Admin",
    password: "Password123",
    database: "travelexperts"
});

// Misc. site configuration
const brand = "Travel Experts";

// Start the server and listen on the chosen {_port}
function startServer(_port) {
    server = app.listen(_port, () => { console.log("Server started on port: " + _port); })
}

// Express middleware for parsing bodies from URL
app.use(bodyParser.urlencoded({ extended: true }));

// Use the files in the "public" folder
app.use(express.static("public"));

// Set the view engine to use .pug templates
app.set("views", path.join(__dirname, "views"));
app.set("view engine", "pug");

// Render the main index view template
app.get(["/", "/index"], (req, res) => {

    var packageSQL =
        "SELECT * " +
        "FROM packages";

    // Open a new MYSQL query with our SQL statement
    con.query(packageSQL, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the bookings view template with the {result} passed in as {data}
        res.render("index", {
            _title: "Travel Experts",
            _brand: brand,
            result: result
        });
    });
    
})
//test123


// Render contact view template
app.get("/contact", (req, res) => {
    var contactsSQL =
        "SELECT * " +
        "FROM agents";

    // Open a new MYSQL query with our SQL statement
    con.query(contactsSQL, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the bookings view template with the {result} passed in as {data}
        res.render("contact", {
            _title: "Contact Us",
            _brand: brand,
            result: result
        });
    });

    
})

// Catch the redirect data and render the thank you view template
app.get("/thanks", (req, res) => {
    res.render("thanks", {
        _title: "Thank You!",
        _brand: brand,
        fullname: req.query.fullname,
        email: req.query.email,
        postal: req.query.postal
    });
});

// Render the bookings view template from an SQL query
app.get("/bookings", (req, res) => {

    // Define SQL statement
    var bookingsSQL =
        "SELECT customers.CustomerName, customers.CustomerEmail, bookings.BookingNo " +
        "FROM customers JOIN bookings " +
        "ON customers.CustomerId = bookings.CustomerId";

    // Open a new MYSQL query with our SQL statement
    con.query(bookingsSQL, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the bookings view template with the {result} passed in as {data}
        res.render("bookings", {
            _title: "Bookings",
            _brand: brand,
            result: result
        })
    });

})

//
app.get("/display-customer", (req, res) => {

    con.query("SELECT CustomerId, CustomerName from Customers", (err, result, fields) => {

        if (err) throw err;

        res.render("display-customer", {
            _title: "Update Customer",
            _brand: brand,
            result: result,
            fields: fields
        });

    });
});

app.get("/display-customer-get", (req, res) => {

    var customerId = req.query.CustomerId;

    con.query({
        sql: "SELECT * FROM customers WHERE CustomerId=?",
        values: [customerId]
    }, (err, result, fields) => {

        if (err) throw err;

        console.log(result, fields);

        res.render("customer", {
            _title: "Update Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

app.get("/display-customer-get-all", (req, res) => {

    con.query("SELECT * FROM customers", (err, result, fields) => {

        if (err) throw err;

        res.render("customer", {
            _title: "Update Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

// custupdate
app.get("/update-customer", (req, res) => {

    con.query("SELECT CustomerId, CustomerName from Customers", (err, result, fields) => {

        if (err) throw err;

        // custselectupdate
        res.render("update-customer-select", {
            _title: "Update Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
})

// get-update
app.get("/update-customer-get", (req, res) => {

    // Define SQL statements
    var customerSQL =
        "SELECT * " +
        "FROM customers " +
        "WHERE CustomerID=?";
    var agentSQL =
        "SELECT AgentID, AgentFirstName, AgentLastName " +
        "FROM AGENTS";

    // Open a new MYSQL query with our SQL statement
    con.query(agentSQL, (err, _agentResult) => {

        // Catch any errors from the query callback
        if (err) throw err;

        var customerId = req.query.customerId;

        // Log the query result to console
        console.log(_agentResult);

        con.query({ sql: customerSQL, values: [customerId] }, (err, result) => {

            // Catch any errors from the query callback
            if (err) throw err;

            // Log the query result to console
            console.log(result);

            // custupdate
            res.render("update-customer", {
                _title: "Update Customer",
                _brand: brand,
                customers: _customersResult,
                agents: _agentResult
            })

        });
    });
})

// post-update
app.post("/update-customer-post", (req, res) => {

    var sql =
        "UPDATE `customers` " +
        "SET `CustomerName`=?,`CustomerPostal`=?,`CustomerEmail`=? `CustomerPassword`=? " +
        "WHERE CustomerId=?";

    var values = [
        req.body.CustomerId,
        req.body.CustomerName,
        req.body.CustomerPostal,
        req.body.CustomerEmail,
        req.body.CustomerPassword,
        req.body.AgentId
    ];

    console.log(values);

    con.query(sql, values, (err, result) => {

        if (err) throw err;

        console.log("Updated " + result.affectedRows + " row(s).");

        if (result.affectedRows) { res.status(200).send("Updated " + result.affectedRows + " row(s)."); }
        else { res.status(200).send("Update failed!"); }

    });
});

// custdelete
app.get("/delete-customer", (req, res) => {

    var deleteSQL =
        "SELECT CustomerId, CustomerName, CustomerPostal, CustomerEmail, CustomerPassword " +
        "FROM customers";

    con.query(deleteSQL, (err, result, fields) => {

        if (err) throw err;

        // custselectdelete
        res.render("delete-customer-select", {
            _title: "Delete Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

// get-delete
app.get("/delete-customer-get", (req, res) => {

    var agentSQL =
        "SELECT AgentID, AgentFirstName, AgentLastName " +
        "FROM AGENTS";

    var customerSQL =
        "SELECT * from customers " +
        "WHERE CustomerId=?";

    con.query(agentSQL, (err, _agentResult, fields) => {

        if (err) throw err;

        var agentResult = _agentResult;
        var customerID = req.query.customerID;

        con.query({ sql: customerSQL, values: [customerID] }, (err, _result) => {

            if (err) throw err;

            console.log(_result);

            res.render("delete-customer", {
                _title: "Delete Customer",
                _brand: brand,
                agentResult: agentResult,
                result: _result
            });
        });
    });
});

// post-delete
app.post("/delete-customer-post", (req, res) => {

    var deleteSQL = "DELETE FROM `customers` WHERE CustomerId=?";

    var values = [req.body.CustomerId];

    con.query(deleteSQL, values, (err, result) => {

        if (err) throw err;

        if (result.affectedRows) { res.status(200).send(result.affectedRows + " row(s) deleted"); }
        else { res.status(200).send("Delete failed!"); }

    });
});

app.get("/insert-customer", (req, res) => {

    con.query("SELECT AgentId, AgentFirstName, AgentLastName FROM agents", (err, result) => {

        if (err) throw err;

        res.render("insert-customer", {
            _title: "Insert Customer",
            _brand: brand,
            result: result
        });
    });
});


app.post("/insert-customer-post", (req, res) => {

    var insertSQL =
        "INSERT INTO customers" +
        "(CustomerName, CustomerPostal, CustomerEmail, CustomerPassword, AgentID) " +
        "VALUES (?,?,?,?,?)";

    var values = [
        req.body.CustomerName,
        req.body.CustomerPostal,
        req.body.CustomerEmail,
        req.body.CustomerPassword,
        req.body.AgentId
    ];

    con.query(insertSQL, values, (err, result) => {

        if (err) throw err;

        if (result.affectedRows) { res.status(200).send(result.affectedRows + " row(s) inserted!"); }
        else { res.status(200).send("Insert failed!"); }

    });
});

// Render error page on 404 error.
app.use((req, res, next) => {
    res.status(404).render("404", {
        _title: "404 Page Not Found",
        _brand: brand
    })
})

// Start the server @ {port}
startServer(port);



