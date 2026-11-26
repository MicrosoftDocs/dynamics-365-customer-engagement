---
title: Azure subscription prerequisites for Connected Customer Service with Azure IoT Hub
description: Learn about Azure subscription prerequisites and considerations when deploying and administering Connected Customer Service with Azure IoT Hub.
ms.date: 03/30/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Azure subscription prerequisites for Connected Customer Service with Azure IoT Hub

[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

When you deploy and administer Connected Customer Service with Azure IoT Hub, your Azure subscription must meet the following prerequisites and considerations.

## Prerequisites 

- You can deploy and administer Connected Customer Service with Azure IoT Hub in only one Azure tenant. This tenant must be the home (primary) Azure tenant associated with your credentials.

- To deploy and administer Azure IoT Hub, you must have one of the following Azure security roles:
  - **Owner** (role assignment)
  - One of the following administrator roles:
    - Co-administrator
    - Service administrator
    - Account administrator

- Only subscriptions associated with your **primary Microsoft Entra ID tenant** are visible in the deployment app.  
  For example, if `david@contoso.com` signs in, only subscriptions from the `contoso.com` directory appear. If `jason@fabrikam.com` invites David to a `fabrikam.onmicrosoft.com` subscription, David can't use that subscription in the deployment app.

- Only organizational Azure accounts can be used to deploy Connected Customer Service with Azure IoT Hub. Personal accounts, such as Outlook.com or Gmail, aren't supported.

- Your user account must have permission to use the Dynamics API within the Microsoft Entra ID tenant.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
