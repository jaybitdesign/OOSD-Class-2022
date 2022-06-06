const mysql = require("mysql");
const bodyParser = require("body-parser");
const express = require("express");
const app = express();
app.set("view engine", "ejs");
app.use(bodyParser.urlencoded( { extended: true } ));

app.listen(8000, (err)=>{
	if (err) throw err;
	console.log("server started on port 8000");
});

function getConnection()
{
	var con = mysql.createConnection({
		host: "localhost",
		user: "harv",
		password: "password",
		database: "travelexperts"
	});
	return con;
}

app.get("/custdisplay", (req, res)=>{
	var con = getConnection();
	con.connect((err)=>{
		if (err) throw err;
		con.query("select CustomerId, CustFirstName, CustLastName from Customers",
			(err, result, fields)=>{
			if (err) throw err;
			res.render("custdisplay", { result: result, fields: fields });
			con.end((err)=>{
				if (err) throw err;
			});
		});
	});
});

app.get("/get-all", (req, res)=>{
	var con = getConnection();

	con.connect((err)=>{
		if (err) throw err;
		con.query("select * from Customers",
			(err, result, fields)=>{
			if (err) throw err;
			res.render("index", { result: result, fields: fields });
			con.end((err)=>{
				if (err) throw err;
			});
		});
	});
});

//usage: http://localhost:8000/get-one?custid=106
//replace the number with the customer id you want to retrieve
app.get("/get-one", (req, res)=>{
	var con = getConnection();

	con.connect((err)=>{
		if (err) throw err;
		var customerId = req.query.custid;
		con.query({
			sql: "select * from Customers where CustomerId=?",
			values: [customerId]
			},
			(err, result, fields)=>{
			if (err) throw err;
			res.render("index", { result: result, fields: fields });
			con.end((err)=>{
				if (err) throw err;
			});
		});
	});
});

