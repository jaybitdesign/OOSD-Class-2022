const mysql = require("mysql");
const express = require("express");
const app = express();
const bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({ extended: true }));
app.set("view engine", "ejs");

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

app.get("/insert", (req, res)=>{
	var con = getConnection();
	con.connect((err)=>{
		if (err) throw err;
		con.query("select AgentId, AgtFirstName, AgtLastName from agents", (err, result, fields)=>{
			
			res.render("custinsert", { result: result });
		});
	});
	
});

app.post("/post-form", (req, res)=>{
	var con = getConnection();
	con.connect((err)=>{
		if (err) throw err;
		var sql = "INSERT INTO `customers`(`CustFirstName`, `CustLastName`, `CustAddress`, `CustCity`, `CustProv`, `CustPostal`, `CustCountry`, `CustHomePhone`, `CustBusPhone`, `CustEmail`, `AgentId`) VALUES (?,?,?,?,?,?,?,?,?,?,?)";
		var values = [req.body.CustFirstName, req.body.CustLastName, req.body.CustAddress, req.body.CustCity, req.body.CustProv, req.body.CustPostal, req.body.CustCountry, req.body.CustHomePhone, req.body.CustBusPhone, req.body.CustEmail, req.body.AgentId];
		con.query(sql,values,(err, result, fields)=>{
			if (err) throw err;
			console.log("result=" + result.affectedRows);
			if (result.affectedRows)
			{
				res.status(200).send(result.affectedRows + " row(s) inserted");
			}
			else
			{
				res.status(200).send("insert failed");
			}
			con.end((err)=>{
				if (err) throw err;
			});
		});
	});
});



