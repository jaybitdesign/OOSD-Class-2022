const mysql = require("mysql");
const express = require("express");
const app = express();
const bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({ extended: true }));
app.set("view engine", "ejs");

app.listen(8000, (err) => {
	if (err) throw err;
	console.log("server started on port 8000");
});

function getConnection() {
	var con = mysql.createConnection({
		host: "localhost",
		user: "harv",
		password: "password",
		database: "travelexperts"
	});
	return con;
}

app.get("/custupdate", (req, res) => {

	var con = getConnection();

	con.connect((err) => {

		if (err) throw err;

		con.query("select CustomerId, CustFirstName, CustLastName from Customers",
			(err, result, fields) => {

				if (err) throw err;

				res.render("custselectupdate", { result: result, fields: fields });

				con.end((err) => {
					if (err) throw err;
				});
			});
	});
});

app.get("/get-update", (req, res) => {

	var con = getConnection();

	con.connect((err) => {

		if (err) throw err;

		con.query("select AgentId, AgtFirstName, AgtLastName from agents", (err, result, fields) => {

			var agentsResult = result;
			var customerId = req.query.custid;

			con.query({ sql: "select * from Customers where CustomerId=?", values: [customerId] },
				(err, result, fields) => {

					if (err) throw err;

					var custResult = result;

					res.render("custupdate", { agentsResult: agentsResult, custResult: custResult });

					con.end((err) => {
						if (err) throw err;
					});
				});
		});
	});
});

app.post("/post-update", (req, res) => {

	var con = getConnection();

	con.connect((err) => {

		if (err) throw err;

		var sql = "UPDATE `customers` SET `CustFirstName`=?,`CustLastName`=?,`CustAddress`=?,`CustCity`=?,`CustProv`=?,`CustPostal`=?,`CustCountry`=?,`CustHomePhone`=?,`CustBusPhone`=?,`CustEmail`=?,`AgentId`=? WHERE CustomerId=?";
		var values = [req.body.CustFirstName, req.body.CustLastName, req.body.CustAddress, req.body.CustCity, req.body.CustProv, req.body.CustPostal, req.body.CustCountry, req.body.CustHomePhone, req.body.CustBusPhone, req.body.CustEmail, req.body.AgentId, req.body.CustomerId];
		
		console.log("sql=" + sql);
		console.log("values=" + values);

		con.query(sql, values, (err, result, fields) => {

			if (err) throw err;

			console.log("result=" + result.affectedRows);

			if (result.affectedRows) {
				res.status(200).send(result.affectedRows + " row(s) updated");
			}
			else {
				res.status(200).send("update failed");
			}

			con.end((err) => {
				if (err) throw err;
			});
		});
	});
});

