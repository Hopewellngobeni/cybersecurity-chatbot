



using System;
using System.Threading;
using System.Linq;

namespace SoundPlayer
{
    public class Chatbot
    {
        // Constructor 
        public Chatbot()
        {
            // Ask for the user's name
            Console.ForegroundColor = ConsoleColor.Blue; 
            
            // AIChat name in blue
            Console.Write("AiChat:-> ");

            // ask for name input
            Console.ResetColor();
            Console.WriteLine("Enter your name");

            // Store user's name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("User:-> ");
            string name = Console.ReadLine();

            // Greet the user
            DisplayAiChat($"Hello, {name}");

            // Introduction message
            DisplayAiChat("How are you? Welcome to the Cybersecurity AI Chatbot! What can I help you with today?");

            // Topics the AI will show
            string[] topics = { "passwords", "phishing", "safe browsing", "cybersecurity" , "are you" , "purpose"};

            //  Responses (meaning and purpose)
            string[] responses = {
                // Passwords
                "Passwords are the first line of defense against unauthorized access. Strong passwords should:\n" +
                "- Contain at least 12-16 characters.\n" +
                "- Use a mix of uppercase, lowercase, numbers, and symbols.\n" +
                "- Be unique for each account.",

                // Phishing
                "Phishing is a type of cyber attack where attackers impersonate trusted sources to steal sensitive information. \n" +
                "Types of phishing attacks include:\n" +
                "- **Email Phishing**: Fake emails asking for login credentials.\n" +
                "- **Spear Phishing**: Targeted attacks against individuals or organizations.\n" +
                "- **Smishing & Vishing**: SMS and voice call scams.\n" +
                "- **Fake Websites**: Websites designed to look like real services (e.g., banking sites).\n" +
                "To avoid phishing:\n" +
                "- Don't click on suspicious links or attachments.\n" +
                "- Verify email sender addresses.\n" +
                "- Enable spam filters and security software.",

                // Safe Browsing
                "Safe browsing involves protecting yourself while using the internet. Key practices include:\n" +
                "- Always check if websites use HTTPS (secure connection).\n" +
                "- Avoid clicking on pop-ups and suspicious ads.\n" +
                "- Use a Virtual Private Network (VPN) for security on public Wi-Fi.\n" +
                "- Regularly update browsers and security software.\n" +
                "- Avoid downloading files from untrusted sources.",

                // Cybersecurity
                "Cybersecurity is the practice of protecting systems, networks, and data from cyber threats. It includes:\n" +
                "- **Network Security**: Protecting internet connections from attacks.\n" +
                "- **Endpoint Security**: Securing devices like laptops and mobile phones.\n" +
                "- **Data Protection**: Encrypting and backing up sensitive information.\n" +
                "- **User Awareness**: Educating people about threats like phishing and malware.\n" +
                "The goal of cybersecurity is to ensure confidentiality, integrity, and availability of data.",
               
                
                //how are you
                "am ouk thanks and you",

                //Purpose
                "My purpose is to provide the user with help regarding cybersecurity"
            };

            // Words to ignore 
            string[] ignoreWords = { "tell", "me", "about", "is", "how", "can", "help", "define", "what", "explain", "your" };

            // Looping for user interaction
            while (true)
            {
                // Ask user for a cybersecurity-related question
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{name}:-> ");
                Console.ResetColor();
                string input = Console.ReadLine().ToLower();

                // Exit condition
                if (input == "quit")
                {
                    DisplayAiChat("Goodbye! Stay safe online.");
                    break;
                }

                // Remove ignored words from input
                string filteredInput = string.Join(" ", input.Split(' ').Where(word => !ignoreWords.Contains(word)));

                // Find the index of the topic in the array
                int index = Array.IndexOf(topics, filteredInput);
                string response = index != -1 ? responses[index] : "I did not quite understand that. Could you please rephrase?";

                // AI "thinking" delay
                DisplayAiChat("Generating...");
                Thread.Sleep(1000);

                // AI response
                DisplayAiChat(response);

                // Ask if user needs further assistance
                DisplayAiChat("Can I help with anything else?");
            } // end of while
        } // end of constructor

        // Typing effect with AIChat label
        private void DisplayAiChat(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AiChat:-> ");
            Console.ResetColor();
            TypingEffect(message);
        }

        // Typing effect method
        private void TypingEffect(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
            Console.ResetColor();
        } // end of TypingEffect method
    } // end of the Chatbot class
} // end of namespace

