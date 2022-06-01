const englishGreetings = ["Hello", "Long time, no see", "Pleased to meet you", "How do you do", "How do you do"];
const frenchGreetings = ["Salut", "Coucou!", "Bonsoir", "Enchanté", "Bonjour"];

function selectGreeting(x) {
    const rand = Math.floor(0 + Math.random()*(4 - 0 + 1))
    if(x == "english") {
        return englishGreetings[rand];
    } else if (x =="french") {
        return frenchGreetings[rand];
    } else {
        return "Error when choosing greeting language."
    }
}

exports.englishGreeting = selectGreeting("english");
exports.frenchGreeting = selectGreeting("french");