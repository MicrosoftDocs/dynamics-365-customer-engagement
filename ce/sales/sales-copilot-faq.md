---
# Required metadata
# For more information, see https://review.learn.microsoft.com/en-us/help/platform/learn-editor-add-metadata?branch=main
# For valid values of ms.service, ms.prod, and ms.topic, see https://review.learn.microsoft.com/en-us/help/platform/metadata-taxonomies?branch=main

title:       Sales Copilot FAQ
description: Includes frequently asked questions on Sales Copilot
author:      lavanyakr01 # GitHub alias
ms.author:    lavanyakr
ms.topic:    concept
ms.date:     07/27/2023
---

# Sales Copilot FAQs
Here are some FAQs for customers using Sales Copilot in Dynamics 365 Sales.

**Q. How does the data flow between Dynamics and AOAI endpoints?** <br>
All requests are encrypted and on secure endpoints

**Q. What data is included in the requests?** <br>
This is entirely based off the type of interaction. When you attempt to summarize your opportunity the revelant fields of the given records and associated metadata is pushed to the AOAI endpoint to generate a summary.

**Q. Is any of my data retained outside my CRM?** <br>
We do not retain any of your data in any new data store.

**Q. How is the data encrypted?** <br>
All data continues to be handled according to the Microsoft data management guidelines. See [here](https://www.microsoft.com/en-us/trust-center/privacy/data-management).

**Q. What privacy controls apply to the data received by the AOAI service?** <br>
All data continues to be handled according to the Microsoft privacy guidelines. See [here](https://learn.microsoft.com/en-us/compliance/assurance/assurance-privacy).

**Q. Have we opted out of abuse monitoring and human review?** <br>
Yes we have.

**Q. Where are the AOAI endpoints hosted?<br>**
Currently we have AOAI resources in NAM and EUR. If your Dynamics environment is in NAM or EUR all requests are routed to your geo's endpoint. For all other geos your data will be routed outside of your geo boundary, if you enable Sales copilot. See details at [Dynamics 365 Sales Copilot data movement](https://learn.microsoft.com/en-us/dynamics365/sales/sales-copilot-data-movement).

**Q. Is any of my data used to train any AOAI/LLM models?** <br>
No. We do not use any customer data to train any AOAI or any other LLM models.

