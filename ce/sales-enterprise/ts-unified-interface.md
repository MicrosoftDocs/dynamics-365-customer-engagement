---
title: "Troubleshooting issues with the Unified Interface (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with Unified Interface in Dynamics 365 Sales."
ms.date: 03/24/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting issues with the Unified Interface

This article helps you troubleshoot and resolve issues related to the Unified Interface.

<a name="read_only"> </a>
## Issue: Out-of-the-box or custom entities appear as read-only in the Unified Interface apps

Some out-of-the-box and custom entities are appearing as read-only in the Sales Hub app (Unified Interface). However, these entities are editable in the legacy web client. Some out-of-the-box buttons are also unavailable on the forms in the Unified Interface.

**Reason:**

This could happen when an entity is set to be read-only in mobile. 

**Resolution:**

To resolve this: 

1.    On the navigation bar in your app, select the **Settings** icon and then select **Advanced Settings**.

    ![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens in a new browser tab.

2.    On the navigation bar, select **Settings** and then select **Customizations**.

    ![Select Customizations](media/customization-in-sitemap.png "Select Customizations")
 
3.    On the **Customization** page, select **Customize the System**.

4.    In the solution explorer, under **Components**, expand **Entities** and then select the specific entity that's appearing as read-only.

5.    On the **General** tab, under **Outlook & Mobile**, clear the **Read-only in mobile** check box.

    ![Setting to make an entity read-only in mobile](media/read-only-in-mobile-setting.png "Setting to make an entity read-only in mobile")
 
6.    Save and publish the customizations.

7.    In the Sales Hub app, refresh the window. 

All the out-of-the-box actions will be available and entities will be editable. 


### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  