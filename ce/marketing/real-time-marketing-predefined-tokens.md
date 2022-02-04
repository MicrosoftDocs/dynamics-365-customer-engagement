---
title: "Preview: Personalize emails using pre-defined tokens (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to personalize content in Dynamics 365 Marketing."
ms.date: 02/07/2022
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

# Preview: Personalize emails using pre-defined tokens

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Personalized messages help marketers drive engagement. A common way to personalize content is to use dynamic text (placeholder text or tokens) that is automatically replaced with recipients' personal details at the time the message is sent. For example, rather than using a generic greeting like “Dear customer,” you can use dynamic text (“Dear ``{{FirstName}}``) that will be replaced by the customer name (for example, “Dear John”).

An instance of placeholder text such as ``{{Firstname}}`` is called a token. Before you can use such tokens they first have to be defined with 3 pieces of information: 

1.	Data binding – Where the replacement data for this token will come from (e.g., “firstname” attribute of “Contact” table)
1.	Label – How it is referred to within the message text (e.g., {{Firstname}}
1.	Default value – What text to use in case source data is empty

Defining data binding requires some understanding of the Dataverse data model to correctly connect a token to the right data source.
Pre-defined tokens are tokens that have already been defined by someone else and are ready to be used. Marketing ships with a set of commonly used pre-defined tokens and more can be added by you or your teammates (see 3.How to create and share pre-defined tokens).

> [!NOTE]
> Pre-defined tokens are currently available only in English. They will be available in all languages at the time of general availability.
