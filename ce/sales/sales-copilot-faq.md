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
When you type a query in copilot we pass the relevant data to AOAI via our plugins and services. We will release a high level architecture document around the GA timeframe.

**Q. What data is included in the requests?** <br>
This varies as per the type of request made. For eg. when you attempt to summarize your opportunity the revelant fields of the opportunity and associated metadata is pushed to the AOAI endpoint to generate a summary.

**Q. Is any of my data retained outside my CRM?** <br>
We do not retain any of your data in any new data store. To detect and mitigate abuse, Azure OpenAI stores all prompts and generated content securely for up to thirty (30) days. You can read more about the AOAI data and privacy committments [here](https://learn.microsoft.com/en-us/azure/ai-services/openai/faq#data-and-privacy)

**Q. How is the data encrypted?** <br>
All data continues to be handled according to the Microsoft data management guidelines. See [here](https://www.microsoft.com/en-us/trust-center/privacy/data-management).

**Q. What privacy controls apply to the data received by the AOAI service?** <br>
All data continues to be handled according to the Microsoft privacy guidelines. See [here](https://learn.microsoft.com/en-us/compliance/assurance/assurance-privacy). You can read more about the AOAI data and privacy committments [here](https://learn.microsoft.com/en-us/azure/ai-services/openai/faq#data-and-privacy)

**Q. Where are the AOAI endpoints hosted?<br>**
Currently we have AOAI resources in NAM and EUR. If your Dynamics environment is in NAM or EUR all requests are routed to your geo's endpoint. For all other geos your data will be routed outside of your geo boundary, if you enable Sales copilot. See details at [Dynamics 365 Sales Copilot data movement](https://learn.microsoft.com/en-us/dynamics365/sales/sales-copilot-data-movement).

**Q. Is any of my data used to train any AOAI/LLM models?** <br>
No. We do not use any customer data to train any AOAI or any other LLM models.

