---
title: "View the primary domain name in Dynamics 365 | MicrosoftDocs"
description: "Instructions to view the primary domain name for a portal in Dynamics 365."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 28AD6523-EED8-4C02-89D5-A9703883966B
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# View the primary domain name in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

When you provision a portal, the domain name is stored in the **Primary Domain Name** field on the website record. If any change is made to the domain name through the Portal Administration Center, the latest domain name is stored in the **Primary Domain Name** field. If you have not created a custom domain name, the vanity domain name is stored in the **Primary Domain Name** field.

If a portal user manually changes the value in the **Primary Domain Name** field, the value is updated only if it is one of the valid domain names.

For example:

The existing domain name is contoso.microsoftcrmportals.com. The initial value of the **Primary Domain Name** field is set to contoso.microsoftcrmportals.com.

You configure a custom domain name as myportal.com. The updated value of the **Primary Domain Name** field is myportal.com.
Let’s take the following scenarios:
- **Scenario 1**: If a portal user changes the **Primary Domain Name** field value to yourportal.com, the value of the field will be reverted to myportal.com, which is the primary domain name.
- **Scenario 2**: If a portal user changes the **Primary Domain Name** field value to contoso.microsoftcrmportals.com, the value of the field will be retained because it is one of the valid domain names.

To view the primary domain name in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]:
1.	Sign in to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].
2.	Go to **Portals** > **Website** > **Websites**.
3.	Select the website for which you want to see the primary domain name.
4.	View the name stored in the **Primary Domain Name** field under the **General** section.

    ![View primary domain name](media/view-primary-domain-name.png "View the primary domain name")  
