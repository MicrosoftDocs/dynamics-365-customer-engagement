---
title: "Restrict access to a portal by using IP address in Dynamics 365 | MicrosoftDocs"
description: "Instructions to restrict portal access by IP address."
ms.custom: 
  - dyn365-portal
ms.date: 10/01/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: A947E701-8760-485C-9102-3A0573B01379
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Restrict portal access by IP address

Dynamics 365 Portal is used by various customers, the provisioned portal is public, and it is accessible by anyone from any computer. This feature allows a customer to restrict access to their portals from a list of IP addresses. For example, a government organization might want to surface their content only within their corporate network. A commercial organization might want to display the portal only when it is published and not while it is development to avoid any data leak.

When a request to the portal is generated from any user, their IP address is evaluated against the allow list. If the IP address is not in the list, the portal replies with an HTTP 403 status code.

> [!NOTE]
> You must be a portal administrator to add or remove IP addresses.

## Add an IP address

To allow access to a portal from an IP address or a set of IP addresses, you can add the IP addresses to the list. This allows the portal to be accessed only from the list of added IP addresses. If you do not add any IP address, the portal will be accessible from all IP addresses.

1.	Go to the Dynamics 365 Administration Center page and select the **Applications** tab.

2.	Select the name of the portal for which you want restrict access by IP address, and then select **Manage**.

3.	Go to **Set up IP address restriction**. A list of IP addresses and their type are displayed.

4.	On the Set up IP address restriction page, select **Add an IP address (+)**.
5.	In the Add an IP address window, enter the following values:

  - **Select type of IP address**: Select if the IP address is IPv4 or IPv6.
  - **Specify IP address in CIDR notation**: Specify the IP address in CIDR notation. 

6.	Select **Configure**.

## Remove an IP address

To remove access to a portal from a previously allowed IP address, you can remove the IP address from the list. If you remove all IP addresses, the portal will be accessible from all IP addresses.

1.	Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2.	Select the name of the portal for which you want restrict access by IP address, and then select **Manage**.
3.	Go to **Set up IP address restriction**. A list of IP addresses and their type are displayed.
4.	Select **Remove an IP address (x)** next to the IP address to be removed.
5.	Select **Remove** in the confirmation message.

