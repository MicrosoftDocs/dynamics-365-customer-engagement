---
title: "Delete Omnichannel solutions | MicrosoftDocs"
description: "Learn how to delete a Omnichannel solution from an organization."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 9DD734AE-8137-427C-A4BE-F4B2A0E58C00
ms.custom: 
---

# Delete Omnichannel solutions

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

When you upgrade Omnichannel for Customer Service to the latest release, certain managed solutions appear in the **Solutions** page of your Common Data Service platform. After the upgrade is complete, you must delete the solution from the previous release if the upgrade does not delete. In addition, if your organization is using **Customer Service Hub** app, then you must delete the app from the channel configuration in the **Channel Integration Framework** app.

## Delete OmnichannelCustomerServiceHub solution

The steps describe how to delete the solution from your organization.

<<<<<<< HEAD
1. Sign in to the Dynamics 365 apps.
=======
1. Sign in to the Common Data Service platform.
>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869

    > [!Note]
    > When you sign in to a different app in your organization, then select the default model-driven app and perform the steps 2 and 3.

2. On the nav bar select the down arrow button, and choose **Settings** > **Solutions**.

3. On the **Solutions** page, select the **OmnichannelCustomerServiceHub** solution and then choose **Delete**. 

4. A confirmation message appears prompting you to uninstall the managed solution. Choose **OK**. 

    > [!div class=mx-imgBorder]
    > ![Delete Omnichannel Solution](../media/oceh-admin-delete-solution.png "Delete Omnichannel Solution")  

You have deleted the **OmnichannelCustomerServiceHub** solution from your organization.

## Remove Customer Service Hub from channel provider configuration

The steps describe how to delete the solution from your organization.

<<<<<<< HEAD
1. Sign in to Dynamics 365 apps.
=======
1. Sign in to the Common Data Service platform.
>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869

2. Select the drop-down button on Dynamics 365 and select **Channel Integration Framework**.
   
3. Select the record that is related to omnichannel.
   
4. Remove **Customer Service Hub** from the **Select Unified Interface Apps for the Channel** section.
   
5. Select **Save** to save the record.

## See also

- [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)
- [Omnichannel for Customer Service on Unified Service Desk](omnichannel-customer-service-unified-service-desk.md)
- [Deploy Unified Service Desk - Omnichannel for Customer Service package](omnichannel-customer-service-package.md)
