---
title: "Provision unified routing in Customer Service | MicrosoftDocs"
description: "Learn how to provision unified routing in Customer Service."
ms.date: 10/17/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Provision unified routing for Customer Service

Perform the steps mentioned in this topic to provision unified routing in Customer Service. By default, unified routing is not enabled.

## Provision unified routing for only Customer Service

To provision unified routing in Customer Service, do the following:

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

   1. In the site map, select **Routing**. The **Routing** page appears.
   
   1. Select **Manage** for **Turn on Unified Routing for Records**.

   ### [Customer Service Hub](#tab/customerservicehub)

   - Go to the **Service Management** site map, and select **Service Configuration Settings** in **Service Terms**. The **Service Configuration Settings** page appears.

1. If consent is already provided by the tenant administrator, go to **Step 5**.

    If consent to access is not provided by the tenant administrator, in the **Unified routing** section, the following message with a link to the consent page will be displayed:

      "Unified routing requires application permissions. A tenant administrator must provide consent before it can be turned on. Provide consent."

1. Select **Provide consent**. The following consent form is displayed on a new tab.

    > [!div class=mx-imgBorder]
    > ![Consent to allow access to data.](media/data-consent.png "Consent to allow access to data")

    For information on consent, see [Consent to access data to provision Omnichannel for Customer Service](data-access-consent.md)

1. Select **Consent on behalf of your organization**, and select **Accept**.

1. After access is granted, you can close the page to return to the **Service Configuration Settings** page.

1. Set the toggle to **Yes** for **Turn on unified routing**. A message that unified routing is being provisioned appears.

After unified routing is provisioned, **Unified routing successfully provisioned** message appears above the toggle key.

### Provision unified routing in Customer Service with Omnichannel for Customer Service

When Omnichannel for Customer Service is available but not deployed, in the **Service Configuration Settings** page, the following message will appear:

  "Some required services need to be installed before unified routing can be turned on. Please contact Microsoft Support."

When Omnichannel for Customer Service doesn't have the required solutions, the following message will appear:

  "Before unified routing can be turned on, Omnichannel needs to be updated. Please contact Microsoft Support."

> [!NOTE]
> **Unified Routing** also appears in the site map if you install or upgrade Omnichannel for Customer Service.

### Next steps

![Next step.](media/right-arrow.png) [Set up the user as a bookable resource](users-user-profiles.md)  
![Home.](media/home-button.png) [Process for setting up unified routing](set-up-routing-process.md)  

### See also

[Provide consent to access data](data-access-consent.md)  
[Set up record routing](set-up-record-routing.md)  
[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
