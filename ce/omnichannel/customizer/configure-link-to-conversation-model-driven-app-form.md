---
title: "Configure link to conversation button in model-driven app entity form | MicrosoftDocs"
description: "Learn how to configure link to conversation button in model-driven app form for agents using Omnichannel for Customer Service."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: C54F8B67-721F-4C39-BD55-A98A3A4BCBA2
ms.custom: 
---

# Preview: Configure link to conversation button in model-driven app entity form

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Introduction

This topic describes, as a system customizer, how to configure the **Link to conversation** button in the model-driven app entity form for agents using Omnichannel for Customer Service app.

When an agent accepts a conversation request and there is no record in the Omnichannel for Customer Service linked to this conversation. Now, the agent want to search for a contact or account record, and link the record to the conversation. As a system customizer, you need to configure the **Link to conversation** button in the model-driven app entity form so agents could link a record to the current conversation. 

To add the **Link to conversation** button in the model-driven app entity form, as a system customizer, you need to customize the ribbon (`<RibbonDiffXml>`) definition. The customization change definitions that you specify are applied at runtime when the ribbon is displayed in the application.

With latest release of Omnichannel for Customer Service base solutions, you get the web resources to add the **Link to conversation** button.

## Customize the entity ribbon to add Link to conversation button

To add the **Link to conversation** button, you need to customize the ribbon (`<RibbonDiffXml>`) of the entity. You need to edit the ribbon in the Form context of the entity.

