const mysql = require("mysql");

var con = mysql.createConnection({
	host: "localhost",
	user: "harv",
	password: "password",
	database: "travelexperts"
});

con.connect((err)=>{
	if (err) throw err;
	con.query("select * from Customers", (err, result, fields)=>{
		if (err) throw err;
		console.log(fields);
		console.log(result);
		con.end((err)=>{
			if (err) throw err;
		});
	});
});