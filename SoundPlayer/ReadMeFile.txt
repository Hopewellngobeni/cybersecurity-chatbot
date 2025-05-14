POE CHATBOT APP

This is a C# console application that simulates an AI chatbot named AiChat, designed to educate users about 
cybersecurity topics like phishing, passwords, encryption, and more. It provides helpful tips, detects user 
sentiment, and responds with empathy.

What does the chatbot do?
Greets the user and asks for their name.
Asks the user to share their favorite cybersecurity topic.
Responds to user questions about cybersecurity.
Offers random useful tips based on keywords.
Detects simple emotions like "worried", "curious", or "frustrated", and responds kindly.
Has a typing effect and uses colors to separate AI and user input.
Allows the user to type “exit” to quit the chat.

Cybersecurity Topics Covered:
Passwords
Phishing
Safe Browsing
Scams
Cybersecurity (General)
Privacy
Encryption
Wi-Fi Security
System & Software Updates

Sentiment Detection (Empathetic Responses):
The chatbot can detect if the user is feeling:

Worried
Frustrated
Curious
Scared
Confused

EG.
User: "I'm worried about scams."
Chatbot: "It's completely understandable to feel that way. Let me share some helpful advice to ease your concerns."

 How It Works (Summary of the Code):
I used a dictionary to store common topic names and simplify user input.
I used arrays to store several tips for each topic.
Picks a random tip from the array when the topic is asked.
Filters out extra words like “tell”, “about”, etc., to focus on keywords.
Displays responses using a typing effect for realism.
Detects simple emotions in user input and responds before giving tips.
Continues to chat until the user types "exit".

 User Interface (Console Colors):
Green for user input.
Blue for chatbot name ("AiChat").
White for chatbot messages with typing effect.

 Technologies Used:
C# Console Application
Loops, Arrays, Dictionaries, String Methods
Random class to select different responses
Thread.Sleep for a typing effect

 How to Use It:
Run the application.
Type your name.
Choose your favorite cybersecurity topic.
Ask questions or type keywords (like "passwords", "encryption").
Feel free to express feelings like "worried", and the bot will respond kindly.
Type exit when you're done