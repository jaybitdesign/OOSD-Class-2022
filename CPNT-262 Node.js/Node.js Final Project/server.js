// Import required libraries
const express = require("express");
const path = require("path");
const bodyParser = require("body-parser")
const mysql = require("mysql")

// Set up Express.js
const app = express();

// Express middleware for parsing bodies from URL
app.use(bodyParser.urlencoded({ extended: true }));

// Use the files in the "public" folder
app.use(express.static("public"));

// Set the view engine to use .pug templates
app.set("views", path.join(__dirname, "views"));
app.set("view engine", "pug");

// Misc. site configuration
const brand = "Travel Experts";

// Initialize server variables
const port = 8000;
var server = null;
var con = mysql.createConnection({
    host: "localhost",
    user: "Admin",
    password: "Password123",
    database: "travelexperts"
});

// Start the server and listen on the chosen {_port}
function startServer(_port) {
    server = app.listen(_port, () => { console.log("Server started on port: " + _port); })
}

// Render the main index view template
app.get(["/", "/index"], (req, res) => {

    // Define SQL statement(s)
    var packageSQL =
        "SELECT * " +
        "FROM packages";

    // Open a new MYSQL query with our SQL statement
    con.query(packageSQL, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the bookings view template with the {result} passed in
        res.render("index", {
            _title: "Travel Experts",
            _brand: brand,
            result: result
        });
    });
})

// Render contact view template
app.get("/contact", (req, res) => {

    // Define SQL statement(s)
    var contactsSQL =
        "SELECT * " +
        "FROM agents";

    // Open a new MYSQL query with our SQL statement
    con.query(contactsSQL, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the contact view template with the {result} passed in
        res.render("contact", {
            _title: "Contact Us",
            _brand: brand,
            result: result
        });
    });
})

// Render the thanks view template with result from the register query
app.get("/thanks", (req, res) => {
    res.render("thanks", {
        _title: "Thank You!",
        _brand: brand,
        fullname: req.query.fullname,
        email: req.query.email,
        postal: req.query.postal
    });
});

// Render the bookings view template
app.get("/bookings", (req, res) => {

    // Define SQL statement(s)
    var bookingsSQL = "SELECT * FROM `bookings`";

    // Open a new MYSQL query with our SQL statement
    con.query(bookingsSQL, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the bookings view template with the {result}
        res.render("bookings", {
            _title: "Bookings",
            _brand: brand,
            result: result
        })
    });
})

// Render the display-customer view template
app.get("/display-customer", (req, res) => {

    // Open a new MYSQL query with our SQL statement
    con.query("SELECT CustomerId, CustomerName from Customers", (err, result, fields) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the display-customer view template with the {result}
        res.render("display-customer", {
            _title: "Display Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

// Render the display-customer-get view template
app.get("/display-customer-get", (req, res) => {

    // Store CustomerId from the query to a variable
    var customerId = req.query.CustomerId;

    // Open a new MYSQL query with our SQL statement, and pass in CustomerId from query
    con.query({
        sql: "SELECT * FROM customers WHERE CustomerId=?",
        values: [customerId]
    }, (err, result, fields) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Log the query result to console
        console.log(result, fields);

        // Render the customer view template with the {result}
        res.render("customer", {
            _title: "Display Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

// Render the display-customer-get-all view template
app.get("/display-customer-get-all", (req, res) => {

    // Open a new MYSQL query with our SQL statement
    con.query("SELECT * FROM customers", (err, result, fields) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the customer view template with the {result}
        res.render("customer", {
            _title: "Display Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

// Render the update-customer view template
app.get("/update-customer", (req, res) => {

    // Open a new MYSQL query with our SQL statement
    con.query("SELECT CustomerId, CustomerName from Customers", (err, result, fields) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the update-customer-select view template with the {result}
        res.render("update-customer-select", {
            _title: "Update Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
})

// Render the update-customer-get view template
app.get("/update-customer-get", (req, res) => {

    // Define SQL statement(s)
    var customerSQL =
        "SELECT * " +
        "FROM customers " +
        "WHERE CustomerID=?";

    // Store the CustomerId from the query in a variable
    var customerId = req.query.CustomerId;

    con.query({ sql: customerSQL, values: [customerId] }, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Render the update-customer view template with {customersResult} and {agentResult}
        res.render("update-customer", {
            _title: "Update Customer",
            _brand: brand,
            customers: result,
        })
    });
});


// Render the update-customer-post view template
app.post("/update-customer-post", (req, res) => {

    // Define SQL statement(s)
    var sql =
        "UPDATE `customers` " +
        "SET `CustomerName`=?,`CustomerPostal`=?,`CustomerPassword`=?,`CustomerEmail`=? " +
        "WHERE `CustomerId`=?";

    // Store values from the URL body in an array
    var values = [
        req.body.CustomerName,
        req.body.CustomerPostal,
        req.body.CustomerPassword,
        req.body.CustomerEmail,
        req.body.CustomerId
    ];

    // Log the query result to console
    console.log(values);

    // Open a new MYSQL query with our SQL statement
    con.query(sql, values, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log("Updated " + result.affectedRows + " row(s).");

        // Display the amount of rows updated
        if (result.affectedRows) { res.status(200).redirect("display-customer-get-all"); }

        // Display an error
        else { res.status(200).send("Update failed!"); }

    });
});

// custdelete
app.get("/delete-customer", (req, res) => {

    // Define SQL statement(s)
    var deleteSQL =
        "SELECT CustomerId, CustomerName, CustomerPostal, CustomerEmail, CustomerPassword " +
        "FROM customers";

    // Open a new MYSQL query with our SQL statement
    con.query(deleteSQL, (err, result, fields) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Render the delete-customer-select view template with {result}
        res.render("delete-customer-select", {
            _title: "Delete Customer",
            _brand: brand,
            result: result,
            fields: fields
        });
    });
});

// Render the delete-customer-get view template
app.get("/delete-customer-get", (req, res) => {

    // Define SQL statement(s)
    var agentSQL =
        "SELECT AgentID, AgentFirstName, AgentLastName " +
        "FROM AGENTS";
    var customerSQL =
        "SELECT * from customers " +
        "WHERE CustomerId=?";

    // Open a new MYSQL query with our SQL statement
    con.query(agentSQL, (err, _agentResult, fields) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Store the CustomerId from the query in a variable
        var customerID = req.query.CustomerID;

        con.query({ sql: customerSQL, values: [customerID] }, (err, _result) => {

            // Catch any errors from the query callback
            if (err) throw err;

            // Log the query result to console
            console.log(_result);

            // Render the delete-customer view template with {agentResult} and {result}
            res.render("delete-customer", {
                _title: "Delete Customer",
                _brand: brand,
                agentResult: _agentResult,
                result: _result
            });
        });
    });
});

// Render the delete-customer-post view template
app.post("/delete-customer-post", (req, res) => {

    // Define SQL statement(s)
    var deleteSQL = "DELETE FROM `customers` WHERE CustomerId=?";

    // Store the CustomerId from the URL body in a variable
    var values = [req.body.CustomerId];

    // Open a new MYSQL query with our SQL statement
    con.query(deleteSQL, values, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Display the amount of rows deleted
        if (result.affectedRows) { res.status(200).redirect("display-customer-get-all"); }

        // Display an error
        else { res.status(200).send("Delete failed!"); }

    });
});

// Render the insert-customer view template
app.get("/insert-customer", (req, res) => {

    // Render the insert-customer view template with {result}
    res.render("insert-customer", {
        _title: "Insert Customer",
        _brand: brand
    });
});

// Render the insert-customer-post view template
app.post("/insert-customer-post", (req, res) => {

    // Define SQL statement(s)
    var insertSQL =
        "INSERT INTO customers" +
        "(CustomerName, CustomerPostal, CustomerEmail, CustomerPassword) " +
        "VALUES (?,?,?,?)";

    // Store values from the URL body in an array
    var values = [
        req.body.CustomerName,
        req.body.CustomerPostal,
        req.body.CustomerEmail,
        req.body.CustomerPassword
    ];

    // Open a new MYSQL query with our SQL statement
    con.query(insertSQL, values, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Display the amount of rows inserted
        if (result.affectedRows) { res.status(200).redirect("display-customer-get-all"); }
        else { res.status(200).send("Insert failed!"); }

    });
});

// Render the booking view template
app.get("/booking", (req, res) => {

    // Define SQL statement(s)
    var customerSQL = "SELECT CustomerId, CustomerName from customers";
    var packageSQL = "SELECT PackageId, PackageName, PackageDesc FROM packages WHERE PackageId=?";

    // Open a new MYSQL query with our SQL statement
    con.query(customerSQL, (err, customers) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(customers);

        // Store the CustomerId from the query in a variable
        var packageId = req.query.packageId;

        con.query({ sql: packageSQL, values: [packageId] }, (err, packages) => {

            // Catch any errors from the query callback
            if (err) throw err;

            // Log the query result to console
            console.log(packages);

            // Render the update-customer view template with {customersResult} and {agentResult}
            res.render("booking", {
                _title: "New Booking",
                _brand: brand,
                customers: customers,
                packages: packages
            })
        });
    });
});

// Render the insert-customer-post view template
app.post("/booking-post", (req, res) => {

    // Define SQL statement(s)
    var insertSQL =
        "INSERT INTO bookings" +
        "(BookingDate, CustomerId, PackageId) " +
        "VALUES (?,?,?)";

    // Store values from the URL body in an array
    var values = [
        new Date(),
        req.body.CustomerId,
        req.body.PackageId
    ];

    // Open a new MYSQL query with our SQL statement
    con.query(insertSQL, values, (err, result) => {

        // Catch any errors from the query callback
        if (err) throw err;

        // Log the query result to console
        console.log(result);

        // Display the amount of rows inserted
        if (result.affectedRows) { res.status(200).redirect("bookings") }

        else { res.status(200).send("Insert failed!"); }

    });
});

// Render error view template on 404 error
app.use((req, res, next) => {
    res.status(404).render("404", {
        _title: "404 Page Not Found",
        _brand: brand
    })
})

// Start the server @ {port}
startServer(port);



