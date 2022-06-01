const http = require('http');
const greetings = require('./greetings');

const hostname = '127.0.0.1';
const port = 8000;

var server = null;
var name = "";

const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.question('Who are you?', input => {
    if(input == "") {
        name = "Default User"
    } else {
        name = input;
    }
    readline.close();
    startServer();
});

function startServer() {
    server = http.createServer((req, res) => {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/plain');
        res.end();
    })

    server.listen(port, hostname, () => {
        console.log(greetings.englishGreeting + ", " + name + "!")
        console.log(`Your server is now running at http://${hostname}:${port}/`);
    });
}



