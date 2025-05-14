



using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

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
            DisplayAiChat(" Welcome to the Cybersecurity AI Chatbot! my name is Ai Chat ");
            DisplayAiChat("The topics covered in this chat are passwords, phishing, safe browsing , \n " +
                "cybersecurity, scam ,privacy , system and updates , encryption , wifi security \n" +
                "please type exit to end the chat");


            //fav topic
            DisplayAiChat("What is your favourite cybersecurity topic");

            string favTopic = Console.ReadLine().ToLower();

            // Dictionary to map input variations to standard topics
            Dictionary<string, string> topicMap = new Dictionary<string, string>()
{
    { "password", "passwords" }, { "passwords", "passwords" },
    { "phishing", "phishing" },
    { "safe browsing", "safe browsing" }, { "browsing", "safe browsing" },
    { "cybersecurity", "cybersecurity" },
    { "scam", "scam" }, { "scams", "scam" },
    { "privacy", "privacy" },
    { "system and updates", "system and updates" }, { "system and update", "system and updates" },
    { "encryption", "encryption" },
    { "wifi", "wifi security" }, { "wifi security", "wifi security" }, { "wi-fi", "wifi security" }, { "wi-fi security", "wifi security" }
};



            DisplayAiChat($"ok {name}, i will remember that your favourite topic is {favTopic}.");

            DisplayAiChat($" {name},What can i help you with today ");

            // general topics to ask the Ai
            string[] topics = { "are you" , "purpose" , "favourite topic" };

            //  Responses (meaning and purpose)
            string[] responses = {



                 //how are you
                "am ouk thanks and your self",

                //Purpose
                "My purpose is to provide the user with help regarding cybersecurity",
                
                //favorite topic
                $" Your favouriote topic is {favTopic} like you said ",

             };

            // Random tip arrays with answers

            //phishing
            string[] phishingTips = {
    "Be cautious of emails asking for personal information.",
    "Check URLs by hovering over links before clicking.",
    "Never download attachments from unknown sources.",
    "Verify email sender addresses before replying."
};
            //passwords
            string[] passwordTips = {
    "Use a long passphrase with symbols and numbers.",
    "Never reuse the same password across multiple sites.",
    "Change your passwords regularly to stay secure.",
    "Use a password manager to generate and store strong passwords.",
    " Be unique for each account."
};
            //safebrowsing
            string[] safeBrowsingTips = {
    "Use a secure browser and enable pop-up blockers.",
    "Always verify the website address starts with HTTPS.",
    "Avoid logging into personal accounts on public Wi-Fi.",
    "Don’t click on suspicious pop-ups or ads."
};
            //scam
            string[] scamTips = {
    "Scammers may pretend to be people you trust—always verify.",
    "Don't respond to messages that create urgency or fear.",
    "Ignore messages offering prizes or asking for money upfront.",
    "Report scams to authorities or the platform where it happened."
};
            //cybersecurity
            string[] cybersecurityTips =
            {
                "- **Network Security**: Protecting internet connections from attacks." ,
                "- **Endpoint Security**: Securing devices like laptops and mobile phones." ,
                "- **Data Protection**: Encrypting and backing up sensitive information." ,
                "- **User Awareness**: Educating people about threats like phishing and malware." ,
                "The goal of cybersecurity is to ensure confidentiality, integrity, and availability of data.",
            }; 
            //wifisecurity
            string[] wifisecurityTips = {
                "Wi-Fi security is about protecting your wireless internet connection from hackers, unauthorized users, and data theft.",
                "Set a strong Wi-Fi password – Use a mix of letters, numbers, and symbols." ,
                "Change the default router name (SSID) – Avoid using names like \"HomeWiFi\" or \"Admin.\" ",
                "Disable remote access – Prevent people from logging into your router from outside your network. ", 
                "Keep your router firmware updated – Just like your phone or computer, routers need updates to stay safe. "
            };
            //system and updates
            string[] systemandupdatesTips =
            {
                "Software and systems updates are improvements made by developers to fix problems, add new features, and improve security in applications and operating systems. " ,
                "Fix security bugs – Hackers often exploit weaknesses in outdated software. Updates patch these holes. " ,
                "Improve performance – Updates can make software run smoother and faster. " ,
                "Add new features – Developers might include new tools or settings. ",
                "Protect against new threats – As cyber threats evolve, updates add new defenses.",
            };
            //encryption
            string[] EncryptionTips = { 
                                
                "Encryption is a way of protecting information by converting it into a secret code so that only authorized people can read it. ",
                "Protects sensitive information like passwords, bank details, and personal messages. ",
                "Keeps online communications private, even if someone intercepts them. ", 
                "Prevents data theft in case of hacking or device loss. ",
            };

            //privacy
            string[] privacyTips =
            {
         "Privacy in cybersecurity refers to the right to keep your personal information safe and under your control. It means protecting your data—like your name, " +
         "address, phone number, passwords, messages, and online activity—from being seen, used, or shared without your permission " ,
                "Protects your identity from theft or misuse. " ,
                "Keeps your communications confidential, like messages, emails, and phone calls. " ,
                "Limits tracking of your online behavior by websites, advertisers, or hackers. " ,
                "Prevents scams and fraud by keeping your information out of the wrong hands."
            };

            Random rand = new Random();


            // Words to ignore 
            string[] ignoreWords = { "tell", "me", "about", "is", "how", "can", "help", "define", "what", "explain", "your" ,  "online" , "give" , "tip" , "tips" , "on" , "a" , "s" , "great" , "good" , "my" , "i" };

            Dictionary<string, string> sentimentMap = new Dictionary<string, string>();
            sentimentMap.Add("worried", "It's completely understandable to feel that way. Let me share some helpful advice to ease your concerns.");
            sentimentMap.Add("frustrated", "I'm here to help. Cybersecurity can be tricky, but we’ll work through it together.");
            sentimentMap.Add("curious", "Great to hear you're interested! Here's something that might answer your curiosity.");
            sentimentMap.Add("scared", "It's okay to feel scared — threats can be intimidating, but being informed is your best defense.");
            sentimentMap.Add("confused", "No worries! Let’s simplify it step by step.");

            // Looping for user interaction
            while (true)
            {
                // Ask user for a cybersecurity-related question
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{name}:-> ");
                Console.ResetColor();
                string input = Console.ReadLine().ToLower();

                bool sentimentDetected = false;

                foreach (KeyValuePair<string, string> pair in sentimentMap)
                {
                    string sentimentWord = pair.Key;
                    string sentimentResponse = pair.Value;

                    if (input.Contains(sentimentWord))
                    {
                        DisplayAiChat(sentimentResponse);
                        sentimentDetected = true;
                        break; // Respond only to the first matching sentiment
                    }
                }



                // Exit condition
                if (input == "exit")
                {
                  
                    DisplayAiChat("Goodbye! Stay safe online.");
                    break;
                    
                }

                string filteredInputRaw = string.Join(" ", input.Split(' ').Where(word => !ignoreWords.Contains(word)));
                string filteredInput = topicMap.ContainsKey(filteredInputRaw) ? topicMap[filteredInputRaw] : filteredInputRaw;


                // Find the index of the topic in the array
                int index = Array.IndexOf(topics, filteredInput);
                string response;

                if (filteredInput == "phishing")
                    response = phishingTips[rand.Next(phishingTips.Length)];

                else if (filteredInput == "passwords")
                    response = passwordTips[rand.Next(passwordTips.Length)];

                else if (filteredInput == "safe browsing")
                    response = safeBrowsingTips[rand.Next(safeBrowsingTips.Length)];

                else if (filteredInput == "scam")
                    response = scamTips[rand.Next(scamTips.Length)];

                else if (filteredInput == "cybersecurity")
                    response = cybersecurityTips[rand.Next(cybersecurityTips.Length)];

                else if (filteredInput == "wifi security")
                    response = wifisecurityTips[rand.Next(wifisecurityTips.Length)];

                else if (filteredInput == "system and updates")
                    response = systemandupdatesTips[rand.Next(systemandupdatesTips.Length)];

                else if (filteredInput == "encryption")
                    response = EncryptionTips[rand.Next(EncryptionTips.Length)];

                else if (filteredInput == "privacy")
                    response = privacyTips[rand.Next(privacyTips.Length)];

                else if (index != -1)
                    response = responses[index];

                else
                    response = "I did not quite understand that. Could you please rephrase?";


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

