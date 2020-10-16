---
title: "Sample marketing segments (Dynamics 365 Marketing) | Microsoft Docs"
description: "A set of example marketing segments to show various capabilities of natural language understanding in Dynamics 365 Marketing"
keywords: examples; segments; dynamic segments
ms.date: 10/16/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: get-started-article
ms.assetid: c4de5589-b20f-4318-8443-7485c5b1a27b
author: v-jziobro
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status: draft
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Examples of natural language use in segments

Natural Language Understanding (NLU) built into the Marketing capability of Dynamics 365 can help you build dynamic and static segments without learning all the specifics of the Common Data Model (CDM). Most of the examples in this topic will reflect dynamic segments, as static segments are created by manually selecting each member instead of building queries that can find matching results for you, automatically updating the segment as the status of the members changes.

## Sample segments

Using the instructions in [Working with segments](create-segments.md), you can create a segment that will evaluate your Dynamics 365 organizational database for people living in a certain area who are a certain age, for example.

You might name the new segment “Customers who live in Chicago over age 40” and then define the segment as follows:
 - Customers who live in Chicago over age 40

A more complex segment that includes both profile and behavioral queries gives better results that let you make a better[targeted customer journey, perhaps helping reactivate a lapsed customer. For instance, you can create a segment that includes:
 - Customers who live in Chicago over age 40
 - Accounts that have purchased in the last 180 days
 - Contacts with email bounces

This segment would find a group of customers who have purchased from your company in the last six months in Chicago that are now unreachable through the email address in your organizational database, suggesting that a new contact needs to be established for that customer, requiring an outreach channel other than email.

You might also wish to promote a new product or service to existing customers who, based on the type of company they represent, might use it but have not purchased from that category before. This dynamic segment might include:
 - Companies in the healthcare industry with annual revenue over $20 million and that have at least two physical locations
 - Accounts that have purchased in the past year
 - Accounts that have purchased marketing materials in the past and
 - Contacts that have attended your trade-show booth in the past two years
 - Contacts who have purchasing authority who have opened marketing emails in the last 180 days

Contacts in this segment might be more receptive to an email marketing campaign about protective signage than a generic customer list, and it allows for a targeted customer journey more likely to succeed.

> [!TIP]
> Marketing segments are not always processed in the order that the query blocks are expressed, so it’s better to express queries in the positive “customers who have purchased in the past 90 days” than to exclude contacts with a negative or suppression segment  like “customers who have not purchased in the past 180 days”.  Dynamic segments can be created to include, intersect, or exclude contacts in segments, allowing you to build more complex queries.

### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Design dynamic demographic or firmographic segments](segments-profile.md)
