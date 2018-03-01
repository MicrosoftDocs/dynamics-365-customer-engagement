---
title: "First time setup troubleshooting and FAQ (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Solutions to common questions and issues that can occur during the initial setup of Dynamics 365 for Marketing"
keywords: "troubleshooting;setup"
ms.date: 01/31/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4c2bc52f-595c-4728-9ef5-5e3281ca0cc0
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# First time setup FAQ and troubleshooting

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Read this topic to find answers to common questions and solutions to known issues that can sometimes occur during the initial setup of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

<a name="preview-prerequisites"></a>

## Get all prerequisites in place to set up a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview

You can install and use a preview version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] for free. Prerequisites for the preview are the same as those for the production version of the product, but you can install it on a trial (or production) [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant, and you must use it with a trial version of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

- _If you already have an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant_, then you can install the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] preview there simply by requesting the preview. The [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] preview setup installs a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial at the same time and configures the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview to run on that trial. You can't install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview on a production version of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. See [Sign up for the Dynamics 365 for Marketing preview](#marketing-preview-signup) for instructions.

- _If you don't already have an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant_, or if you want to set up a temporary one especially for running the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview, then you can set up a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial, which creates its own [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant trial at the same time. Then you can install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview on that tenant. See [Sign up for a Dynamics 365 trial that includes a trial Office 365 tenant](#D365-preview-signup) for instructions.

<a name="marketing-preview-signup"></a>

### Sign up for the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] preview

Once you have a trial or production [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant, you can install the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] preview on it. The [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] preview creates its own [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial to run on if needed. You can't run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview on a production version of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. To sign up for the preview:

1. Open a web browser and go to [trials.dynamics.com/Dynamics365/Preview/Marketing](https://trials.dynamics.com/Dynamics365/Preview/Marketing).

1. A form opens asking for your email address and phone number. Use the email address that you use to sign into your [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant (or the one you created when setting up a trial tenant).

1. Follow the instructions on your screen.

1. When you get to the **Welcome to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] Setup** message, follow the instructions given in [First time setup](purchase-setup.md).

<a name="D365-preview-signup"></a>

### Sign up for a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial that includes a trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant

If you don't already have a [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant where you'd like to run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview, then you can set up a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial, which creates its own [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant trial at the same time, and then install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview there.

1. Open a web browser and go to [trials.dynamics.com](https://trials.dynamics.com/).

1. Scroll down past the icons and then select the **Sign up here** link next to "Are you signing up on behalf of a customer or using this trial for development purposes?"  
    ![Location of the sign up here link](media/trial-signup1.png "Location of the sign up here link")

1. A dialog box opens. Choose the **No, continue signing up** link.  
    ![Select continue signing up](media/trial-signup2.png "Select continue signing up")

1. A form opens, requesting your contact details. Enter your information.
    > [!IMPORTANT]
    > You must register in a country/region where the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview is available

1. Continue by following the instructions on your screen and providing the information requested. The last page of the setup asks you to choose a scenario. Be sure to choose **All of these**, which makes sure your new [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user account gets created with system admin privileges, and then select **Complete Setup**.
    ![Choose to enable all the apps](media/trial-signup3.png "Choose to enable all the apps")

1. After a few minutes, your new [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization will be ready and will open in your browser. Be sure to make a note of your org's URL and your other account details, such as the user name, password, and email address you chose while setting it up.

1. This step is optional, but it can be useful to set up an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial so you can set up email accounts to use with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial. 

    1. Open a new browser tab and go to [portal.office.com/adminportal/home?rc=1#/catalog](https://portal.office.com/adminportal/home?rc=1#/catalog). This is where you can add new apps to your new org.

    1. Scroll down to the **Office 365 Enterprise E3** box. Hover your mouse over this box to open a flyout message and then select **Start free trial** on the message.

    1. Follow the instructions on your screen to add the trial to your account.

    1. You can now go to the [!INCLUDE[pn-office-365-admin-center](../includes/pn-office-365-admin-center.md)] to assign an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] license to your user account and then set up an [!INCLUDE[pn-exchange](../includes/pn-exchange.md)] mailbox for yourself. You could also set up [!INCLUDE[pn-exchange](../includes/pn-exchange.md)] to forward all messages to your usual work address. See the [!INCLUDE[pn-office-365-admin-center](../includes/pn-office-365-admin-center.md)] online help for assistance with these tasks. It may take several minutes for your mailbox to come online.

1. Install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview on your new trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant as described in [Sign up for the Dynamics 365 for Marketing preview](#marketing-preview-signup).

## Authorization fails due to unmanaged organization state

In some cases, when you sign up for a trial of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] or [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)], you will receive an organization that is in an _unmanaged_ state, which means, (among other things) that you can't get permission to install third-party solutions&mdash;including [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. As a result, you'll see the following error message when you run the setup form for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]:

![Unmanaged org error](media/setup-ts-unmanaged-aad.png "Unmanaged org error")

To fix this, do one of the following:
- If you are just setting up a preview or trial of [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)], then consider creating a new trial tenant and then set up the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] preview there, as described earlier under [Get all prerequisites in place to set up a Marketing preview](#preview-prerequisites).
- If you want to continue using the tenant where you received this error, then you must convert your unmanaged org into a managed one and then run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup form again. For instructions about how to do this, see [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/p/?linkid=866761).
