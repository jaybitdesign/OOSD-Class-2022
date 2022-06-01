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
const contacts =
    [
        {
            "contactName": "Contact #1",
            "contactPhone": "(111) XXX-XXXX",
            "contactEmail": "email1@email.com",
            "contactPhoto": "/img/1.jpg"
        }, {
            "contactName": "Contact #2",
            "contactPhone": "(222) XXX-XXXX",
            "contactEmail": "email2@email.com",
            "contactPhoto": "/img/2.jpg"
        }, {
            "contactName": "Contact #3",
            "contactPhone": "(333) XXX-XXXX",
            "contactEmail": "email3@email.com",
            "contactPhoto": "/img/3.jpg"
        }
    ]

// Start the server and listen on the chosen {_port}
function startServer(_port) {
    server = app.listen(_port, () => { console.log("Server started on port: " + _port); });
}

// Express middleware for parsing bodies from URL
app.use(bodyParser.urlencoded({
    extended: true
}));

// Use the files in the "public" folder
app.use(express.static("public"));

// Set the view engine to use .pug templates
app.set("views", path.join(__dirname, "views"));
app.set("view engine", "pug");

// Render the main index view template
app.get(["/", "/index"], (req, res) => {
    res.render("index", {
        _title: "Travel Experts",
        _brand: brand
    });
})

// Render contact view template
app.get("/contact", (req, res) => {
    res.render("contact", {
        _title: "Contact Us",
        _brand: brand,
        contactA: contacts[0],
        contactB: contacts[1],
        contactC: contacts[2]
    });
})

// Render register view template
app.get("/register", (req, res) => {
    res.render("register", {
        _title: "Register Now",
        _brand: brand
    });
})

// Catch the register form and redirect it to thank you view template
app.post("/register", (req, res) => {
    res.redirect(
        "/thanks?" +
        "fullname=" + req.body.fullname +
        "&email=" + req.body.email +
        "&postal=" + req.body.postal
    );
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

// Render all bookigns from the SQL query
app.get("/bookings", (req, res) => {

    // Open a connection to our MYSQL server
    con.connect(function (err) {

        // Catch any errors from the connect callback
        if (err) throw err;

        // Define SQL statement
        var sql =
            "SELECT customers.CustFirstName, customers.CustLastName, bookings.BookingNo " +
            "FROM customers JOIN bookings " +
            "ON customers.CustomerId = bookings.CustomerId";

        // Open a new query from our MYSQL server
        con.query(sql,
            (err, result)=> {

                // Catch any errors from the query callback
                if (err) throw err;

                // Log the query result to console
                console.log(result);

                // Render the bookings view template with the {result} passed in as {data}
                res.render("bookings", {
                    _title: "Bookings",
                    _brand: brand,
                    data: result
                })

                // End the connection to our MYSQL server
                con.end(function (err) {

                    //Catch any errors from the end connection callback
                    if (err) throw err;

                });
            }
        );
    });
    
})

// Render error page on 404 error.
app.use((req, res, next) => {
    res.status(404).render("404", {
        _title: "404 Page Not Found",
        _brand: brand
    })
})

// Start the server on {port}
startServer(port);



