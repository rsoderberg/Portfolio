# NewsArticleWebScraper
###### Once every fourty seconds, scan the desired webpage(s) home page for results matching a set of select key words.  
###### Each day, send a newsletter-style email with the previous day's results including the title and URL for each article.  
---
#### Method
##### Libraries:  
NLog - Simple logging platform to capture errors and log information to file.  
AngleSharp - Parse HTML, CSS, and XML from the web.
##### Storage:
Each day's results are saved to a text file so there is minimal data loss if the application is shut down or crashes, and so articles can be referred back to by the user at a later date.