---
title: "Preview: Natural language use in segments (Dynamics 365 Marketing) | Microsoft Docs"
description: "Example marketing segments to show various capabilities of Natural Language Query in Dynamics 365 Marketing."
ms.date: 03/30/2021
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

# Preview: Natural language use in segments

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/videoplayer/embed/RE4IQy2" frameborder="0" allowfullscreen=""></iframe></div>

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

> [!NOTE]
> You will need your administrator to [turn on the feature switch](admin-feature-switches.md) for the **Segmentation Natural Language Queries** functionality under **Segmentation** before you are able to access it.

> [!IMPORTANT]
> The the natural language feature for segments currently only supports English language queries.

If your administrator has enabled the natural language feature, you can use Natural Language Query (NLQ) to build segments in Dynamics 365 Marketing. Natural language input enables you to use common words and phrases to describe the people you want to include in dynamic and static segments without learning all the specifics of the Common Data Model (CDM) and best practices for building queries.

Using the instructions in [Working with segments](segmentation-lists-subscriptions.md), type and submit a statement, and the service will fill the query fields using information collected from your contacts, accounts, leads, and activities.

<!--- Most of the examples in this topic will reflect dynamic segments, as static segments are created by manually selecting each member instead of building queries that can find matching results for you, automatically updating the segment as the status of the member contacts and accounts change. -->

## Sample segments

You can create a segment that will evaluate your Dynamics 365 organizational database for contacts that meet certain criteria. For example, contacts living in a certain area who have an email address.

You might name the new segment “Contacts who live in Chicago with email and an upcoming birthday” and then define the segment as follows:

 - Contacts who live in Chicago with an email address and with a birthday in the next month

## Example: Contacts who live in Chicago with an email address and with a birthday in the next month

### Building the segment

- Remember to enter the phrases using normal language. You could enter, "Contacts who live in Chicago with an email address and with a birthday in the next month."
- Give the segment a descriptive name that will help you find it later.

### Reviewing the results

- After going live with the segment, select **Members** to review the results.

## Example: A more complex segment

A more complex segment that includes both profile and behavioral queries gives better results that let you make a better-targeted customer journey, perhaps helping reactivate a lapsed customer. For instance, you can create a segment that includes:

- Contacts who live in Chicago who have an email address (profile).
- Account name is Ford and status is active and revenue is larger than $1,000,000 (profile).

This segment would find a group of contacts who have purchased from your company in the last six months in Chicago that are now unreachable through the email address in your organizational database, suggesting that a new email needs to be established for that contact.

## Phrases you can use in natural language queries

You can use a variety of phrases to find contacts and accounts with various attributes. This is not a complete list.

- Find contacts by location
    - Contacts who live in Atlanta
    - Contacts who live in New York State
    - Contacts in Canada
    - Contacts near Seattle

- Find contacts who share birthdays or anniversaries
    - Contacts whose birthdays are in October
    - Contacts with an anniversary in June

- Find contacts related to accounts
    - Contacts associated with Microsoft company who live in the Czech Republic
    - Contacts associated with Microsoft company born between 1970 and 2000 who have an income greater than $50,000

- Find contacts with upcoming life events
    - Contacts with birthdays next month

- Find accounts missing profile information
    - Companies with no business phone
    - Companies with no contact person or a contact person without a phone number

- Find contacts with particular attributes
    - Find contacts with an email address

<!--- You might also wish to promote a new product or service to existing contacts who, based on the type of company they represent, might use it but have not purchased from that category before. This dynamic segment might include:
 - Companies in the healthcare industry with annual revenue over $20 million and that have at least two physical locations
 - Accounts that have purchased in the past year
 - Accounts that have purchased marketing materials in the past and
 - Contacts that have attended your trade-show booth in the past two years
 - Contacts who have purchasing authority who have opened marketing emails in the last 180 days
Contacts in this segment might be more receptive to an email marketing campaign about protective signage than a generic customer list, and it allows for a targeted customer journey more likely to succeed. -->

> [!TIP]
> Marketing segments are not always processed in the order that the query blocks are expressed, so it’s better to express queries in the positive “contacts who have purchased in the past 90 days” than to exclude contacts with a negative or suppression segment, like “contacts who have not purchased in the past 180 days.” Dynamic segments can be created to include, intersect, or exclude contacts in segments, allowing you to build more complex queries.

### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Design dynamic demographic or firmographic segments](segments-profile.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
