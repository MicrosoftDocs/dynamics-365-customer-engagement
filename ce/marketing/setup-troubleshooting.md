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

Read this topic to find answers to common questions, and solutions to known issues that can sometimes occur during the initial setup of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

## How can I sign up for a trial?

If you'd like to try out [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] for free, then do the following.

### Step 1: Sign up for a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] trial

Even if you already have a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] org in production, you must set up a new trial where you can install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial. 

1. Open a web browser and go to [trials.dynamics.com](https://trials.dynamics.com/).

1. Scroll down past the icons and then select the **Sign up here** link next to "Are you signing up on behalf of a customer or using this trial for development purposes?"  
    ![Location of the sign up here link](media/trial-signup1.png "Location of the sign up here link")

1. A dialog box opens. Choose the **No, continue signing up** link.  
    ![Select continue signing up](media/trial-signup2.png "Select continue signing up")

1. A form opens requesting your contact details. Enter your information.
    > [!IMPORTANT]
    > You must register in a country/region where the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial is available

1. Continue by following the instructions on your screen and providing the information requested. The last page of the setup asks you to choose a scenario. Be sure to choose **All of these** (which makes sure your new [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] user account gets created with system admin privileges) and then select **Complete Setup**.
    ![Choose to enable all the apps](media/trial-signup3.png "Choose to enable all the apps")

1. After a few minutes, your new [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] organization will be ready and open in your browser. Be sure to make a note of your org's URL and your other account details (such as the user name, password, and email address you chose while setting it up).

### Step 2: Add an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3 trial to your new trial org

This step is optional, but it can be useful to set up an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial so you can set up email accounts to use with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial.

1. Open a new browser tab and go to [portal.office.com/adminportal/home?rc=1#/catalog](https://portal.office.com/adminportal/home?rc=1#/catalog). This is where you can add new apps to your new org.

1. Scroll down to the **Office 365 Enterprise E3** box. Hover your mouse over this box (to open a flyout) and then select **Start free trial** on the flyout.

1. Follow the instructions on your screen to add the trial to your account.

1. You can now go to the [!INCLUDE[pn-office-365-admin-center](../includes/pn-office-365-admin-center.md)] to assign an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] license to your user account and then setup an Exchange mailbox for yourself. You could also set up exchange to forward all messages to your usual work address. See the [!INCLUDE[pn-office-365-admin-center](../includes/pn-office-365-admin-center.md)] online help for assistance with these tasks. It may take several minutes for your mailbox to come online.

### Step 3: Sign up for the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial

1. Open a new browser tab and go to [trials.dynamics.com/Dynamics365/Preview/Marketing](https://trials.dynamics.com/Dynamics365/Preview/Marketing).

1. A form opens asking for your email address and phone number. Use the email address created for your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] trial.

1. Follow the instructions on your screen.

1. When you get to the **Welcome to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] Setup** message, follow the instructions given in [First time setup](purchase-setup.md).



## Authorization fails due to unmanaged organization state

In some cases, when you sign up for a trial of [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)], you will receive an organization that is in an _unmanaged_ state, which means (among other things), that you can't get permission to install third-party solutions&mdash;including [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. As a result, you'll see the following error message when you run the setup wizard for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]:

![Unmanaged org error](media/setup-ts-unmanaged-aad.png "Unmanaged org error")

To fix this, you must convert your unmanaged org into a managed one and then run the setup wizard again. For instructions about how to do this, see [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/p/?linkid=866761).