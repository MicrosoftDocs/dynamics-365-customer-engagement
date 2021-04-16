---
title: "Frequently asked questions about unified routing | MicrosoftDocs"
description: "Learn about the frequently asked questions (FAQs) for unified routing in Customer Service and Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# FAQs about unified routing in Customer Service, Omnichannel for Customer Service

## Overview

This topic contains the FAQs that you as an administrator, supervisor, or agent might have about unified routing.

### What SKUs must I have to get unified routing?​

Customers will get unified routing for entities, such as Cases, Leads, and Custom Entity as a part of the Customer Service Enterprise license. When you purchase channels (Chat and Digital messaging), you'll get unified routing for those channels automatically.

### What will happen to my current workstreams after unified routing is installed?

For messaging channels, a migration utility will be available to upgrade the workstream and associated routing rules. For entity routing, you'll configure new workstream and rules in unified routing.

### Will unified routing support activity routing?​

Yes, unified routing supports routing activities, including email.

### Will intelligent skill finder be available in all geographical regions?​

Intelligent skill finder requires AI Builder to create and train the machine learning (ML) model. If AI Builder is not available in the customer region where unified routing is, the customer will get a generic error when trying to setup the model​.

### Can I use intelligent skill finder with email activities?

Yes, intelligent skill finder can be enabled for any entity that is enabled for routing by using any text-based field. For email body skill finder, an additional step is required because email body (description) includes HTML tags that can impact the ML model. You'll extract the text from HTML, copy it into another text field, then configure the ML model against the new field.


### See also

[Overview of unified routing](overview-unified-routing.md)  
[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
