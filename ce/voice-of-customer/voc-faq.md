---
title: "Voice of the Customer FAQ | MicrosoftDocs"
description: "Frequently asked questions in Voice of the Customer"
keywords: voice of the customer FAQ; voice of the customer frequently asked questions
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 592F664E-D6A5-4A90-8B7E-07BC85212A96
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.reviewer: 
topic-status: Drafting
ms.custom:
  - dyn365-VoC
---

# Voice of the Customer FAQ

> [!IMPORTANT]
> Voice of the Customer (VoC) is being deprecated and replaced with Microsoft Forms Pro. [Learn more](https://go.microsoft.com/fwlink/p/?linkid=2097704)

We have compiled a list of frequently asked questions and provided brief answers to help you get to your information quickly.

## How to install Voice of the Customer solution earlier than 9.0?

Voice of the Customer for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] is a preferred solution that you install from [!INCLUDE[pn-ms-office](../includes/pn-ms-office.md)] 365. More information about how to install preferred solutions: [Install a preferred solution](https://technet.microsoft.com/library/dn878909)  

> [!NOTE] 
> If you're using Voice of the Customer version 9.0.781.3 or earlier, maximum number of survey responses you can pull per day is **2,400**.

### Enable and configure Voice of the Customer

After you've installed the Voice of the Customer for Dynamics 365 preferred solution, you need to enable and configure it in Dynamics 365.

1. Go to **Settings** &gt; **Customizations**.

2. Select **Solutions**.

3. In the list of available solutions, select **Voice of the Customer for Dynamics 365**.
 
4. In the **Voice of the Customer for [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] Configuration** screen, select **I agree to the terms and conditions** and select **Enable Voice of the Customer for [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]**.

When the configuration is complete, you can start using the Voice of the Customer for Dynamics 365 solution.

> [!IMPORTANT]
> The Voice of the Customer for Dynamics 365 preferred solution connects to an external service that isn't completely within the Dynamics 365 compliance boundary.

## What happens if I open a survey by using developer tools in a web browser?

If you open a survey by using developer tools in a web browser, the survey might not work properly.

## How to select a date from a date picker in a survey by using keyboard?

The following keyboard shortcuts can be used to select a date from a date picker in a survey:

| To             | Press                                                                           |
|----------------|---------------------------------------------------------------------------------|
| Select a date  | Ctrl + Left Arrow or Ctrl + Right Arrow or Ctrl + Up Arrow or Ctrl + Down Arrow |
| Select a month | Alt + Left Arrow or Alt + Right Arrow                                           |
| Select a year  | Ctrl + Shift + Page Up or Ctrl + Shift + Page Down                              |
|||

## What should I do if survey responses are not received after creating a custom plugin on the Survey Response entity?

The VOC Push Service user runs only with minimum required privileges to communicate to Voice of the Customer Azure service, and if your organization deploys a custom plugin that runs on the Survey Response entity, you are advised to do either of following:
- Run the custom plugin in System User Context.
- Create a custom role with privileges required by custom plugin operations and assign the security role to Voice of the Customer application user.

## What should I do if the survey responses are not submitted successfully in Dynamics 365 apps?

There might be times when a customer has submitted a survey response, but it is not submitted successfully in Dynamics 365 apps. To view the responses that are not submitted successfully: 

1. Open Voice of the Customer app. 

2. Go to Advanced Find and search for the Response Errors entity. 

3. On the **Advanced Find** tab, select **Results**. The response errors along with the associated survey, response ID, error message, error code, and other required details are displayed in a grid format. 

    For example: 

    - If a survey response is not stored in Dynamics 365 apps after trying multiple times, error code 103 is displayed along with the appropriate error message. 
    - If a survey does not exist, error code 201 is displayed along with the appropriate error message. 
    - If a survey invite does not exist, error code 202 is displayed along with the appropriate error message.
