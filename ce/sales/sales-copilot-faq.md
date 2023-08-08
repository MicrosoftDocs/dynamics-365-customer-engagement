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
Here are some frequently asked questions from customers of Sales Copilot in Dynamics 365 Sales.

**Q. How does the data flow between Dynamics and AOAI endpoints?** <br>
When you type a query in copilot, we pass the relevant data to AOAI via our plugins and services. We'll release a high-level architecture document around the GA timeframe.

**Q. Have we opted out of abuse monitoring and human review?**
Yes. Our AOAI resources have opted out of [this feature](https://learn.microsoft.com/en-us/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This helps us ensure we dont retain any of your data outside the dynamics data boundary. We use other techniques to monitor and filter out abusive content at runtime.

**Q. What data is included in the requests?** <br>
The data included in the requests varies as per the type of request made. For example, when you attempt to summarize your opportunity the relevant fields of the opportunity and associated metadata is pushed to the AOAI endpoint to generate a summary.

**Q. Is any of my data retained outside my CRM?** <br>
We don't retain any of your data in any new data store. You can read more about the AOAI data and privacy commitments [here](https://learn.microsoft.com/en-us/azure/ai-services/openai/faq#data-and-privacy)

**Q. How is the data encrypted?** <br>
All data continues to be handled according to Microsoft data management guidelines. See [here](https://www.microsoft.com/en-us/trust-center/privacy/data-management).

**Q. What privacy controls apply to the data received by the AOAI service?** <br>
All data continues to be handled according to Microsoft privacy guidelines. See [here](https://learn.microsoft.com/en-us/compliance/assurance/assurance-privacy). You can read more about the AOAI data and privacy commitments [here](https://learn.microsoft.com/en-us/azure/ai-services/openai/faq#data-and-privacy)

**Q. Where are the AOAI endpoints hosted?<br>**
Currently, we have AOAI resources in NAM and EUR. If your Dynamics environment is in NAM or Europe, all requests are routed to your geo's endpoint. For all other geos, your data will be routed outside of your geo boundary if you enable Sales copilot. See details at [Dynamics 365 Sales Copilot data movement](https://learn.microsoft.com/en-us/dynamics365/sales/sales-copilot-data-movement).

**Q. Is any of my data used to train any AOAI/LLM models?** <br>
No. We don't use any customer data to train any AOAI or any other LLM models.

