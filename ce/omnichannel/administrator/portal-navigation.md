---	
title: "Enable portal navigation | MicrosoftDocs"	
description: "Enable portal navigation in the Omnichannel Administration app."	
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 579DCD1D-3F2A-4948-BA75-10DDD7991E91
ms.custom: 	
---

# Preview: Enable portal navigation

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

The portal navigation feature displays information on the path (recent operations) the customer took just before initiating a conversation. The information enables the agents to understand why a customer reached out and also to provide a personalized service with fast resolution and improved customer satisfaction.

The data that you track as recent actions is stored in an entity where it is passed as part of context with portal navigation type, for a conversation that has been successfully closed between the customer and agent. A portal navigation record is created for each portal navigation action. To learn more, see [msdyn_visitorjourney Entity Reference](../developer/reference/entities/msdyn_visitorjourney.md).

## Prerequisites

- As an administrator, you need to enable the feature for the agents to see the **Portal navigation** tab is displayed to the agents when in a session. To learn more, see [Enable portal navigation](portal-navigation.md#enable-portal-navigation).
- As a developer, you need to enable the portal navigation using the developer experience. To learn more, see [Pass portal navigation history as context](../developer/reference/methods/setcontextprovider.md#pass-customers-portal-navigation-as-context) and [msdyn_visitorjourney](../developer/reference/entities/msdyn_visitorjourney.md#msdyn_type-options). 

## Enable portal navigation

1. Sign in to the Omnichannel Administration app.

2. Select **Portal Navigation** under **Settings**.

3. Set the **Portal Navigation** toggle to **Yes** in the **Omnichannel Configuration** view.

4. Select **Save** to save the changes.

## See also

[Portal navigation](../agent/agent-oc/oc-customer-summary.md#preview-portal navigation)