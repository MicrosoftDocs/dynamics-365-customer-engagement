---
title: "Data access consent | MicrosoftDocs"
description: "Learn about consent requirements that is required for provisioning Omnichannel for Customer Service."
ms.date: 08/12/2021
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.topic: reference
---

# Data access consent for provisioning Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

This topic provides information about the consent that is required to access the different components and data during the installation and provisioning of Omnichannel for Customer Service.

## What is data access consent

Omnichannel for Customer Service app requires the following permissions to read and write data on behalf of users:

- **Create content**: App can automatically create content and datasets for you.

- **Read and write all dashboards**: The app can view and edit all your dashboards and any dashboards that you have access to. 

- **Read and write all reports**: The app can view and edit all your reports and any reports that you have access to. 

- **Read and write user settings and state**: The app can view and edit your user settings and the user-specific state associated with content you have access to. 

- **Read and write all workspaces**: The app can view and edit all workspaces that you have access to. The app can view and edit all workspaces that you have access to. 

- **Sign you in and read your profile**: Allows you to sign in to the app with your work account and let the app read your profile. It also allows the app to read basic company information.

- **Access Common Data Service as you**: Allows the application to access Common Data Service as you.

A detailed explanation is as follows:

- **Permissions Create content, Read and write all dashboard, Read and write all reports, Read and write user settings and state, and Read and write all workspaces**: During the provisioning of Omnichannel for Customer Service, "Omnichannel Insights for Dynamics 365" Power BI app is deployed to gain insights about your customer service omnichannel delivery performance and customer sentiment. The Power BI app consists of the following Power BI components. Omnichannel App needs the read and write permissions to deploy and interact with these components.

    - **Workspace**: Omnichannel Insights for Dynamics 365
    - **Dashboards**:
        - Omnichannel Insights for Dynamics 365
        - Omnichannel Sentiment Analysis (OCSA) for Dynamics 365
    - **Reports**: Omnichannel Insights for Dynamics 365
    - **Datasets**: Omnichannel Insights for Dynamics 365
  
    More information:
     [Omnichannel Insights for Dynamics 365 - Power BI App](https://appsource.microsoft.com/product/power-bi/ms_dynmcsfnp.ms_dynamics_cca_da_oc_analytics)  
     [Omnichannel Insights Dashboard](omnichannel-insights-dashboard.md#omnichannel-insights-dashboard)  
     [Omnichannel Sentiment Analysis dashboard](omnichannel-insights-dashboard.md#omnichannelsentiment-analysisdashboard)  

- **Sign in and read your profile**: This permission allows Omnichannel to sign into the app with user’s work account and let the app read user’s profile. It also allows the app to read basic company information.  