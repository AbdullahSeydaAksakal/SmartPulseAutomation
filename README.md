# SmartPulse Web and Mobile Automation
It is an automation project that enables downloading the Kgüp exel of 30.03.2020 on the web side and sending the PTF average of 05.04.2020 on Mobile as an e-mail. 
## Project Features
* Xunit Architecture was used.
* Written in C# 6.0.net core language.
* Appium library and Appium Inspector tool were used for mobile automation.
* Selenium Web Driver 4.1.0, ChromeWebDriver Libraries were used for regression web automation.
* It was established with an improved Class structure.
* In later versions, specflow(bdd) Clean Code architecture will be established.
* In later versions, multi-layered architecture structures such as Unit, Integration, API testing will be integrated.
* In later processes, independent Cross Browser and OS tests will be run using Docker, Kubernetes technologies.
* Database Architecture will be added.

## Task Requests(UI)
1. Url: "https://seffaflik.epias.com.tr/transparency/uretim/planlama/kgup.xhtml" 
2. Goes to the URL. Downloads the exe of the Kgüp data dated 30.03.2020.

## Task Requests(Mobil)
1. Opens the Epias Mobile application.
2. Sends the PTF average for 05.04.2020 to 'analyst.team@smartpulse.io' via e-mail.
