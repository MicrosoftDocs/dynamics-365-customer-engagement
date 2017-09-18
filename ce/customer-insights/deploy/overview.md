---
title: Overview
description: Customer Insights for Dynamics 365 is a cloud-based SaaS service that enables organizations of all sizes to bring together data from multiple sources and generate knowledge and insights to build a holistic 360° view of their customers. Customer Insights delivers the ability to connect to transactional data sources and model profiles of customers and their interactions. It enables organizations to generate insights through KPI’s about their business. The Customer Insights application transforms the profile, interaction and KPI’s into rich visuals that you can customize and organize to focus on what matters to you.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: a0016eec-3215-4b7c-afd1-0a4789f9f5fe

---
Overview
========
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

##What is Customer Insights? 

Check out the video: [Transform customer data into actionable insights with Dynamics 365 for Customer Insights](https://go.microsoft.com/fwlink/p/?linkid=852574) and this blog: [Dynamics 365 for Customer Insights – In 7 Easy Steps!](https://blogs.msdn.microsoft.com/sachamp/2017/08/25/dynamics-365-for-customer-insights-in-7-easy-steps/)

Dynamics 365 for Customer Insights helps organizations deliver intelligent customer engagement. Customer Insights is an Azure-based SaaS service, that makes it easy to transform your customer data into actionable insights.

Deriving intelligence from data is a multi-step process: data must be brought together from diverse sources, represent them in a normalized form, and establish relationships, before leveraging analytics to arrive at the insights.  Such insights are of limited value until they help us improve productivity, drive collaboration, and service customers better.

Customer Insights makes Big Data easy, by offering a turnkey solution that enables business users to access their customer data; easily, intuitively and continuously apply intelligence; and deliver the resulting insights to the individuals who need it in the context of their day-to-day work.

Customer Insights application experiences include:

- **Customer 360°** to build and visualize the holistic customer journey
- **Predictive Match** to use contextual information to associate activities or profiles with customers across channels
- **Predictive Scoring** that enables business users to predict any business outcome
- **Segmentation** to identify the right audience for your messages based on the entire customer journey

##How Customer Insights works

Customer data isn’t just limited to systems of record, like CRM.  Organizations interact with their customers across a range of different touchpoints, across different channels.  Customer Insights makes it easy to ingest data from various sources, using any of: out-of-box connectors, extensible orchestrations through the Azure ecosystem, and comprehensive REST interfaces.

![](../media/Overview650.png "How Customer Insights works")

Customer Insights has a simple, effective, metadata-driven data model, consisting of Profiles and Interactions.  Profiles aggregate information about any business resource of interest, such as customers, accounts, products, staff, scheduled assets, and more.  Interactions represent events or actions, such as activities, communication, service requests and responses, weather, wi-fi access, surveys, etc.  Relationships represent the connections between profiles, and links map the connections between interactions and participating profiles.

Customer Insights makes it easy to apply advanced analytics to your data.  Business users can:

- **Define KPIs** that are always up-to-date using simple expressions
- **Apply Predictive Match policies** that consist of attributes based on which an activity or profile should be matched to a customer
- **Create Predictions** by simply selecting any business outcome, to automatically apply Predictive AI
- **Generate Segments** that are dynamically updated to add or remove members based on events or actions

Customer Insights provides out-of-box experiences that can be used natively within the service or embedded into other applications or tools, such as Dynamics 365 online, or any other HTML5-based experience.  You also have the option to export insights to Azure Storage.  You can also incorporate insights, such as profiles or KPIs, in reports using a Power BI desktop connector to Customer Insights.

###Security and role-based access control

Customer Insights delivers enterprise-grade security by integrating with Azure Active Directory for role-based access control.  Roles can be assigned rights to access or manage some or all of profiles, interactions, KPIs, Segments, Predictive Match Policies, Predictions, Views or even Widget Types within Views.

- The administrator role enables management and configuration of entities in Customer Insights. 
- The reader role can be granted the rights to access some or all of the entities and/or their metadata.

Users, security groups or any other security principals defined in the tenant’s Azure Active Directory can be associated with the Customer Insights roles.

Customer Insights also supports Shared Access Signature based authorization, that can be used for service-to-service authorization.

###Elastic scale

Customer Insights automatically scales to the capacity you need, based on the incoming data and the associated analytics that you apply.  You have the option to specity the maximum scale utilized to limit your consumption.


