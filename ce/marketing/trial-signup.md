---
title: "Sign up and install a free trial (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to sign up for a trial of Dynamics 365 for Marketing, obtain prerequisite software, and set up the trial"
keywords: "trial"
ms.date: 06/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-admin"
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a52e468a-b81e-4598-aa3a-b0670c333e42
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Sign up for a free trial of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

You can install and use a trial version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] for free.

> [!IMPORTANT]
> Prerequisites for the trial are the same as those for the production version of the product, but you can only install a trial version of [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] on a trial instance of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. However, your trial instance can run on either a production or trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.

> [!IMPORTANT]
> You can install, at most, one [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial per [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.

The procedure for setting up your trial depends on whether you already have a _managed_ [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant (which is a tenant where Azure Active Directory (Azure AD) is available). Nearly all organizations that already use [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] or [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] have managed tenants, but if your organization doesn't currently use any [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] services (or have only ever set up a trial tenant), then you must set up a managed trial tenant first.

- _If you already have a managed tenant_, then you can install the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial there simply by requesting it. The trial setup installs a dedicated [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] trial instance at the same time and configures [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] to run on that trial (you can't install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on a production instance of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]). See [Install the trial on an existing, managed Office 365 tenant](#install-on-existing-tenant) for instructions.
- _If you don't already have an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant_, then you can set up a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] trial that creates its own managed [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial tenant at the same time. Then you can install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on that tenant&mdash;see See [Sign up for a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] trial with a managed [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial tenant](#get-managed-tenant) for instructions.
- _If you already have an unmanaged tenant and prefer to continue using it_, then you must first convert it to a managed one as described in [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/p/?linkid=866761). Then follow the instructions in [Install the trial on an existing, managed Office 365 tenant](#install-on-existing-tenant) to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

If you try to install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on an unmanaged tenant, you'll see the following error message when you try to run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard:

![Unmanaged organization error](media/setup-ts-unmanaged-aad.png "Unmanaged organization error")

<a name="install-on-existing-tenant"></a>

## Install the trial on an existing, managed [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant

To sign up for a free trial of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]:

1. Open a web browser and go to [trials.dynamics.com](https://trials.dynamics.com/).

1. Find and select the **[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]** tile.  
    ![The Marketing trial tile](media/trial-signup-tile.png "The Marketing trial tile")

1. Enter your email address and phone number and choose **Get Started**.

1. The website asks whether you want to use an existing [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant or to create a new one. Choose to use an existing tenant and then follow the instructions on your screen to sign in if needed. (If you want to set up a new tenant, then use the procedure in [Sign up for a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] trial with a managed Office 365 trial tenant](#get-managed-tenant) instead.)

1. Once you are signed in, the tenant will begin setting up a new [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] trial instance with the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial already installed. [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] is a complex app, so this may take some time to set up for your account.

1. When your trial instance is ready you'll receive an email with a link to the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard (the link may also be provided in your browser if you kept the browser open while your tenant set up the instance). Click the link to launch the wizard and then follow the instructions in [Run the setup wizard](purchase-setup.md) as you work through it.

<a name="get-managed-tenant"></a>

## Sign up for a managed [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial tenant and install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on it

If you don't already have a [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant where you'd like to run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial, then you can set up a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial, which creates its own [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant trial at the same time, and then install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial there.

1. Open a web browser and go to [trials.dynamics.com](https://trials.dynamics.com/).

1. Scroll down past the icons and then select the **Sign up here** link next to "Are you signing up on behalf of a customer or using this trial for development purposes?"  
    ![Location of the sign up here link](media/trial-signup1.png "Location of the sign up here link")

1. A dialog box opens. Choose the **No, continue signing up** link.  
    ![Select continue signing up](media/trial-signup2.png "Select continue signing up")

1. A form opens, requesting your contact details. Enter your information.
    > [!IMPORTANT]
    > You must register in a country/region where the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial is available.

1. Continue by following the instructions on your screen and providing the information requested. The last page of the setup asks you to choose a scenario. Be sure to select **All of these**, which makes sure your new [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user account gets created with system admin privileges, and then select **Complete Setup**.  
    ![Choose to enable all the apps](media/trial-signup3.png "Choose to enable all the apps")

1. After a few minutes, your new [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization will be ready and will open in your browser. Be sure to make a note of your org's URL and your other account details, such as the user name, password, and email address you chose while setting it up.

1. This step is optional, but it can be useful to set up an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial so you can set up email accounts to use with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial. 
    1. Open a new browser tab and go to [portal.office.com/adminportal/home?rc=1#/catalog](https://portal.office.com/adminportal/home?rc=1#/catalog). This is where you can add new apps to your new org.
    1. Scroll down to the **[!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3** box. Hover your mouse over this box to open a flyout message and then select **Start free trial** on the message.
    1. Follow the instructions on your screen to add the trial to your account.
    1. You can now go to the [!INCLUDE[pn-office-365-admin-center](../includes/pn-office-365-admin-center.md)] to assign an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] license to your user account and then set up an [!INCLUDE[pn-exchange](../includes/pn-exchange.md)] mailbox for yourself. It may take several minutes for your mailbox to come online, but when it's ready you should consider setting [!INCLUDE[pn-exchange](../includes/pn-exchange.md)] to forward all messages to your usual work address.  To set up forwarding:
        1. Select your new user account. A flyout panel opens.
        1. Expand the **Mail Settings** heading on the flyout panel. (If you see a message that the mailbox is still being set up, then wait for the setup to complete.)
        1. Select the **Edit** link for **Email forwarding**.
        1. Turn forwarding on and specify the target email address. Then select **Save**.
        1. Close the flyout panel.

1. Install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on your new trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant as described in [Install the trial on an existing, managed Office 365 tenant](#install-on-existing-tenant).

## Add more users to a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial running on a trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant

If you followed the instructions provided in the previous section, then you should now have a [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial set up with:

- A trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.
- A trial [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization installed on the trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.
- A trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3 license installed on the trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.
- A trial [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app installed on the trial [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] org.

The user account that you used to set it up is now:

- The global administrator for the trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.
- A system administrator for the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] org.

When you install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on a trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant, as described here, then each new user must be added in a special way. If you set up a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on an existing, non-trial tenant, then new users can just sign up as described in [Sign up for the Dynamics 365 for Marketing trial](#marketing-preview-signup). To add new users to a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial running on a trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant:

1. Open a web browser and go to [portal.office.com](http://portal.office.com). Sign in to your trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant as the global administrator that you set up while signing up for the trial.
1. Once you are signed in, go to [portal.office.com/adminportal/home#/users](http://portal.office.com/adminportal/home#/users) to open the **Active users** page, where you can manage users for the tenant.
1. Select **Add a user** to open the **New user** flyout panel.
1. Enter the new user's name and other details in the flyout panel. 
    - Make sure the **Domain** is the same as the trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.   
    - Create a non-random password and make a note of the password.
    - Under **Product licenses**, enable licenses for both **[!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3** and **[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] Customer Engagement Plan Enterprise Edition**.
1. Select **Add** to create the new user, and then select **Send email and close** to close the flyout panel.

The new user account is now available on your [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant, where it is also assigned trial licenses to [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3 and [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. The user also has an email address at your trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] domain. You should consider setting up mail forwarding to make sure the new user will receive signup messages. To set up forwarding:
1. On the **Active users** page, select the name of the new user account. A flyout panel opens showing details about the selected user.
1. Expand the **Mail Settings** heading on the flyout panel. (If you see a message that the mailbox is still being set up, then wait for the setup to complete.)
1. Select the **Edit** link for **Email forwarding**.
1. Turn forwarding on and specify the target email address. Then select **Save**.
1. Close the flyout panel.
1. Sign out of [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and quit your browser.

Now the new user needs to sign up for the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial. You can either set this up for them or ask them to do it themselves. Either way, you'll need to approve the new user afterwards. The procedure is as follows:
1. Open a web browser and go to [trials.dynamics.com](https://trials.dynamics.com).
1. A form opens asking for your email address and phone number. Use the email address for the new user that you just set up in [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)].
1. A page opens to tell you that you already have an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] account, so just select **Sign in**.
1. Sign in using the [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] email address and password that you created for the new user. 
1. A page opens to tell you that you already have a license for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Select **OK, got it**.
1. You now see a list of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organizations that are available on your trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant (there may be just one). Select the organization that you want to add the new user to and then select **Join**.
1. A dialog box asks you to choose an app. **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]** is probably already shown and selected, so just select **Continue**.
A thank-you page opens telling you that a request has been sent to the trial owner (this is the global admin account created when you first set up the trial org).
1. Sign out of [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and quit your browser.

Check the email inbox for the trial global admin. You should find a message telling you that you have a request to join your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial. 
1. Select the **Approve** link included in the email.
1. The link opens in your browser, which should now be asking you to sign in to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Sign in using the global admin account.

You should now see an **Approved!** message. The system sends the new user an email that includes a link they can use to sign in to the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] trial using the password you chose for them.
The new user is granted most user roles (including admin) in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. If you'd like to restrict access, then see [Assign a security role to a user](manage-users.md#assign-role) for instructions.
