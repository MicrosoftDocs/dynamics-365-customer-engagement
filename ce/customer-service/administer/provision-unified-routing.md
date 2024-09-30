---
title: Provision unified routing in Customer Service
description: Learn how to provision unified routing in Customer Service.
ms.date: 09/13/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.collection:
ms.custom: bap-template
---

# Provision unified routing for Customer Service

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE]
> Case information is applicable only to Customer Service.

Perform the steps mentioned in this topic to provision unified routing in Customer Service. By default, unified routing isn't enabled if only Customer Service is installed.

## Prerequisites

- Ensure that the provisioning user has the following permissions:
  - Microsoft 365 Global admin role. More information: [Assign admin roles to user in Microsoft Office 365](/microsoft-365/admin/add-users/assign-admin-roles)
  - Customer Service Representative or CSR Manager for setting up the unified routing configuration.
  - Dynamics 365 System Administrator role on the root business unit for your organization. More information: [Assign security roles to a user in Power Platform](/power-platform/admin/assign-security-roles) and [Create or edit business units](/power-platform/admin/create-edit-business-units)
  - Read-Write access in the Client Access License Information (CAL). More information: [Create a Read-Write user account in Power Platform](/power-platform/admin/create-users#create-a-read-write-user-account)
- **License required for unified routing**:  
With the Customer Service Enterprise license, you'll get unified routing for tables, such as Cases, Leads, and custom tables. The license for Chat and Digital messaging includes unified routing for chat, SMS, and messaging channels, and the Teams channel. More information: [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)

## Provision unified routing for Customer Service only

1. In the site map of Customer Service admin center or Contact Center admin center, select **Routing**. The **Routing** page appears.
   
1. In **Manage unified routing**, select **Manage**.

1. On the **Manage unified routing** page, switch the toggle to **Yes** for **Unified routing**.

1. Select **Save**. A message that unified routing provisioning is in process appears.

If the provisioning fails, go to [Dynamics 365 Customer Service and Dynamics 365 Contact Center troubleshooting](/troubleshoot/dynamics-365/customer-service/welcome-customer-service) or contact Microsoft Support to help resolve the issue.

### Provision unified routing in Customer Service with omnichannel application

When the omnichannel capabilities are available but not deployed, in the **Service Configuration Settings** page, the following message will appear:

  "Some required services need to be installed before unified routing can be turned on. Please contact Microsoft Support."

When Omnichannel for Customer Service doesn't have the required solutions, the following message will appear:

  "Before unified routing can be turned on, Omnichannel needs to be updated. Please contact Microsoft Support."


### Next steps

![Next step.](../media/right-arrow.png) [Set up the user as a bookable resource](users-user-profiles.md)  
![Home.](../media/home-button.png) [Process for setting up unified routing](set-up-routing-process.md)  

### Related information

[Provide consent to access data](../implement/data-access-consent.md)  
[Set up record routing](set-up-record-routing.md)  
[Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels)  
