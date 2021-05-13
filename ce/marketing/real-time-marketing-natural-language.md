---
title: "Use natural language in real-time marketing journeys (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use natural language in real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 04/30/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Use natural language in real-time marketing journeys

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Natural language input enables you to use common words and phrases to describe a simple condition you want to include in your customer journey. The data model is built on top of Common Data Model (CDM).

## Sample conditions

You can create a segment that will evaluate your Dynamics 365 organizational database for customers that meet a certain criterion. For example, customers with an annual income of $100,000.

### Examples of simple conditional phrases using natural language:

#### Search by company

-	Customers who work at Microsoft (Profile)
-	People that work in a company named Amazon (Profile/Contact)

#### Search by demographic

-	Female customers (Profile)
-	Female contacts (Contacts)
-	Contacts in Seattle (Contacts)
-	Customers who are in Ohio (Contacts)
-	Contacts with vice president as job title (Contacts)
-	Customers with vice president as job title (Contacts/Profile)
	 
#### Search based on customer preferences

-	Customers whose preferred contact method is email (Contacts/Profile)
-	Contacts whose preferred contact method is email (Contacts)
-	Active contacts (Contacts)

#### Search by segment membership within your organization 

-	Customers that are in Loyalty Segment

## Give us feedback

The natural language model is constantly learning. If you try a query that doesn’t work, you are always welcome to provide feedback.

To provide feedback:

1. Select the thumb down icon.
1. Select **Send feedback**.
1. Enter a short explanation of what happened. Add comments about what you would expect the phrase to look like.
