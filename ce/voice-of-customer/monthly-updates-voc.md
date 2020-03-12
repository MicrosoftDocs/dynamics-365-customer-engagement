---
title: "Monthly updates in Voice of the Customer for Dynamics 365 | MicrosoftDocs"
description: "Learn about what's new in the latest release of Voice of the Customer for Dynamics 365."
keywords: what's new in voice of the customer
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 8AFEFC49-D1F6-4BE5-B2D8-C4D22525E8D1
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.reviewer: 
topic-status: Drafting
ms.custom:
  - dyn365-VoC
---

# What's new in Voice of the Customer for Dynamics 365

> [!IMPORTANT]
> Voice of the Customer (VoC) is being deprecated and replaced with Microsoft Forms Pro. [Learn more](https://go.microsoft.com/fwlink/p/?linkid=2097704)

Welcome to Voice of the Customer for Dynamics 365. Here's a list of features we added and updated recently. For more information about the updates that have been made to Voice of the Customer for Dynamics 365 to date, along with additional details about those updates, see [here](https://blogs.msdn.microsoft.com/crm/tag/voice-of-the-customer/).

## Voice of the Customer version 9.0.1162

Following are the new and updated features in this release:

- **Voice of the Customer app**: The Voice of the Customer app provides a new experience in survey designing as well as theme designing. The new survey designer provides a simple and intuitive experience for survey designers to add, remove, and modify survey pages, sections, questions, and answers. When you install Voice of the Customer version 9.0.1162 and higher, the Voice of the Customer app, built on the Unified Interface framework, is created out-of-the-box.

## Voice of the Customer version 9.0.1113.10

Following are the new and updated features in this release:

- **Robust survey translation**: The translation file is now validated for missing string translations and incorrect HTML format. You can also translate the invitation link text to a different locale to personalize it as per the respondent's locale.

- **Validate Voice of the Customer solution for any issues**: You can now validate the status for your Voice of Customer solution. Validation allows you to check whether:
  - Voice of the Customer configuration and provisioning is in proper state.
  - Survey lifecycle is working fine for the organization.
  - Survey responses are being received properly.

  More information:[Validate Voice of the Customer solution](troubleshoot.md#validating-the-voice-of-the-customer-solution)

- **Validate a survey for any issues**: You can now validate a survey for any issues in its configuration. More information: [Validate a survey](troubleshoot.md#validating-a-survey)

- **Design interactive surveys by using answer tag**: You can now personalize a question based on the answer to the previous question by using an answer tag. The answer tag stores the response in a tag that can be replaced in subsequent questions and answers in the survey at run time. More information: [Design interactive surveys by using answer tag](design-advanced-survey.md#design-interactive-surveys-by-using-answer-tag)

- **Add multiple survey snippets to an email**: You can now add multiple survey snippets to an email and send them your respondents.

- **Implement General Data Protection Regulation in Voice of the Customer**: With GDPR being implemented, customers can contact you with view, export, update, and delete requests of their data stored in Dynamics 365. You must take appropriate actions based on the customer's request. More information: [Implement GDPR in Voice of the Customer](implement-gdpr.md)

## Voice of the Customer version 9.0.1027.16

Following are the new and updated features in this release:
- **Cascade delete of survey**: The reliability and experience of survey delete operation are improved. All the dependent entities of a survey are deleted when the survey is deleted. The prerequisite user actions, if required, for deleting the survey are displayed on the screen.
- **Reconfigure Voice of the Customer**: You can now repair or restore the Voice of the Customer configuration if it is accidentally deleted or misconfigured.
