---
title: "Troubleshooting Dynamics 365 - Gamification | Microsoft Docs"
description: "Troubleshoot common issues in Dynamics 365 – Gamification."
ms.custom: 
  - dyn365-gamification
ms.date: 05/05/2020
ms.reviewer:
ms.service: dynamics-365-sales
ms.topic: get-started-article
author: m-hartmann
ms.author: mhart
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Gamification
---

# Troubleshooting guide

## I have installed Gamification from AppSource and get the error "Cannot create organization" while activating.

You should be able to install and activate Gamification if the pre-requisites in [Activate Gamification in Dynamics 365](manage-gamification-in-dynamics-365-online.md#activate-gamification-in-dynamics-365) are met. If you are still facing an issue, please try the following options: 

- The signed in user has a non-empty first name, last name and email address in Microsoft 365. For more information, see [Manage Microsoft 365 User Information](/microsoft-365/admin/add-users/change-a-user-name-and-email-address).

- The signed in user has a Global admin role in Microsoft 365. For more information, see [Manage O365 User Roles](/microsoft-365/admin/add-users/assign-admin-roles).

- The signed in user has a System Administrator role in Dynamics 365. For more information, see [Manage User Roles in Dynamics 365](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user)

- The signed in user has Read-Write license assigned in Dynamics 365. For more information, see [Manage User License in Dynamics 365](/power-platform/admin/create-users-assign-online-security-roles#create-a-read-write-user-account).

If you continue to face issues while activating Gamification, raise a Support request from the Dynamics 365 Admin Center and provide the error details and the timestamp of the error occurrence. 


[!INCLUDE[footer-include](../includes/footer-banner.md)]