---
title: "Sign up and install a free trial (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to sign up for a trial of Dynamics 365 for Marketing, obtain prerequisite software, and set up the trial"
keywords: trial
ms.date: 04/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: a52e468a-b81e-4598-aa3a-b0670c333e42
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Sign up for a free trial of Dynamics 365 for Marketing

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

You can sign up for, install, and use a trial version of Dynamics 365 for Marketing for free.

> [!IMPORTANT]
> - You will receive a trial [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instance together with your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial. You must run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on a trial instance, and can't install it on a production instance.
> - You can install, at most, one [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial per Microsoft 365 tenant.
> - You can only install the trial if you are located in a country/region where the product is supported. To read the latest list of countries/regions where you can use Dynamics 365 for Marketing, download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).

> [!IMPORTANT]
> Your system is constrained by certain limits and quotas that apply to the number of contacts you can market to, monthly email messages you can send, Litmus previews you can view, and more. Please familiarize yourself with the terms and limits of the product before you begin to use it. The limits are different based on whether you are running a trial, preview, or subscribed version of the product.
> 
> - For subscribed (paid) versions, please download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).
> - For trial and previews, see [Dynamics 365 for Marketing limits for trials and previews](trial-preview-limits.md).
> 
> You can keep an eye on your usage levels by going to  **Settings**  >  **Advanced settings**  >  **Other settings**  >  **Quota limits**  in Dynamics 365 for Marketing. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Quota limits](quota-management.md)
> 
> See also the  [Readme](https://go.microsoft.com/fwlink/p/?linkid=864736) document for the latest news and updates.

> [!NOTE]
> If would like help setting up a trial, or if you would prefer to get a guided demo, go to the [Get started with Dynamics 365 for Marketing](https://dynamics.microsoft.com/get-started/?appname=marketing) page and then fill out and submit the **Request a call back** form. You will soon be contacted by a Dynamics 365 sales representative who can help you. To set up your own trial without personal assistance, continue reading this topic.

<a name="choose-tenant"></a>

## Step 1: Choose or prepare your Microsoft 365 tenant

Dynamics 365 for Marketing is a cloud-based application that runs on a *Microsoft 365 tenant*. Your tenant hosts your cloud applications (including [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]), provides user and license management, and much more. The procedure for setting up your trial depends on whether you already have a *managed* tenant (which is a tenant where Azure Active Directory (Azure AD) is available), an unmanaged tenant, or no tenant at all. Nearly all organizations that already use [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] or [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] have managed tenants, but if your organization doesn't currently use any [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] services (or have only ever set up a trial tenant), then you must set up a managed trial tenant first. Do one of the following:

- *If you already have a managed tenant*, then you can install the Dynamics 365 for Marketing trial there simply by requesting it. The trial setup installs a dedicated [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] trial instance at the same time and configures [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] to run on that trial (you can't install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on a production instance of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]). Jump to [Step 2: Install the Dynamics 365 for Marketing trial on your tenant](#install-on-existing-tenant) to continue.
- *If you don't already have a Microsoft 365 tenant*, then you can set up an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] trial that creates its own managed trial tenant at the same time. We recommend that you sign up for an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] E3 trial, which you can do by going to [products.office.com/business/office-365-enterprise-e3-business-software](https://products.office.com/business/office-365-enterprise-e3-business-software). You can also purchase [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] from there. When your trial tenant is ready, continue to [Step 2: Install the Dynamics 365 for Marketing trial on your tenant](#install-on-existing-tenant).
- *If you already have an unmanaged tenant and prefer to continue using it*, then you must first convert it to a managed one as described in [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/p/?linkid=866761). Then continue with [Step 2: Install the Dynamics 365 for Marketing trial on your tenant](#install-on-existing-tenant).

If you try to install the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on an unmanaged tenant, you'll see the following error message when you try to run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard:

![Unmanaged organization error](media/setup-ts-unmanaged-aad.png "Unmanaged organization error")

<a name="install-on-existing-tenant"></a>

## Step 2: Install the Dynamics 365 for Marketing trial on your tenant

To install your trial on a managed tenant:

1. Make sure you have a [managed tenant](#choose-tenant) available.

1. Go to the [Get started with Dynamics 365 for Marketing](https://dynamics.microsoft.com/get-started/?appname=marketing) page and select the **Sign up for a free trial** link to get started.

1. Enter your email address and phone number in the fields provided. Use the email address that you normally use to sign into the tenant where you will install the Marketing trial (or the one created for you if you set up a trial tenant) and choose **Get Started**.    
    ![The Marketing trial tile](media/trial-signup-tile.png "The Marketing trial tile")

1. The website should recognize your email address as belonging to an existing tenant account. If you aren't already signed in, then select **Sign in** and follow the instructions on your screen to sign in.    
    ![Start sign in](media/trial-signin.png "Start sign in")

1. After you are signed in, you'll be presented with some disclaimer text and contact options. Read the text and select the options you prefer. Then select **Create** to start setting up the trial.    
    ![Disclaimers and options](media/trial-almost-there.png "Disclaimers and options")

1. Next, you're asked to allow the new app the permissions it requires on your tenant. Read the information provided carefully. If you agree with the terms, select **Consent on behalf of your organization** and then select **Accept**.    
    ![Accept permissions to continue](media/trial-permissions-requested.png "Accept permissions to continue")

1. A second permissions page opens. Once again, read the information provided carefully. If you agree with the terms, select **Consent on behalf of your organization** and then select **Accept**.    
    ![Accept permissions to continue](media/trial-permissions-requested2.png "Accept permissions to continue")

1. A third settings page now opens, asking for a few more consent permissions and your organization's physical street address.

    - Carefully read the consent text shown for each check box, and follow the links to make sure you understand all the relevant issues. If you agree with the terms, then mark each check box as you go to indicate your consent. Some of these are optional, so you can still use the product without them, though the related features will be disabled. Other features are required, so you won't be able to use Dynamics 365 for Marketing without agreeing to them.

    - Type the full physical street address for your organization in the field provided. All marketing email messages sent by Dynamics 365 for Marketing must include the physical street address of your organization (among several other required elements). These requirements help maximize email deliverability while also helping make sure you conform to common legal requirements for marketing email.  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Best practices for email marketing](get-ready-email-marketing.md)

    ![Provide consent and enter your postal address](media/trial-marketing-setup.png "Provide consent and enter your postal address")

1. Select **Get started** to start setting up your Marketing trial.

1. When you're trial is ready, select **Begin** to go to the app.
    ![Select Begin to get started](media/trial-setup-done.png "Select Begin to get started")

<a name="add-users"></a>


## Add more users to a trial

After you set up a Marketing trial you'll have a Marketing license assigned to the user account you used to set up the trial. Read this section to learn how to grant access to other user accounts.

### Add users to a Marketing trial running on a production tenant

If you set up a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial on a production tenant, then new users can add themselves by going to the trial setup URL (which was sent to you right after you signed up for the trial) and then signing up using their existing Microsoft 365 account. This will add a trial Marketing license to that user's account.

### Add users to a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial running on a trial tenant

If you set up a trial tenant and installed the Marketing trial there, then you should now have the following:

- A trial tenant.
- A trial [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization installed on the trial tenant.
- A trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3 license installed on the trial tenant.
- A trial Dynamics 365 for Marketing app installed on the trial [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] org.

The user account that you used to set it up is now:

- The global administrator for the trial tenant.
- A system administrator for the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] org.

To add a new Marketing user to this type of setup, use the following steps.

#### Step 1: Add a new user account to the trial tenant

Start by adding a new user account to the trial tenant as follows:

1. Open a web browser and go to [admin.microsoft.com](https://admin.microsoft.com). Sign in to your trial tenant as the global administrator that you set up while signing up for the trial.
2. Once you are signed in, go to [admin.microsoft.com/adminportal/home#/users](https://admin.microsoft.com/adminportal/home#/users) to open the **Active users** page, where you can manage users for the tenant.
3. Select **Add a user** to open the **New user** flyout panel.
4. Enter the new user's name and other details in the flyout panel. 
   - Make sure the **Domain** is the same as the trial tenant.   
   - Create a non-random password and make a note of the password.
   - Under **Product licenses**, enable licenses for both **[!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3** and **Dynamics 365 Customer Engagement Plan Enterprise Edition**.
5. Select **Add** to create the new user, and then select **Send email and close** to close the flyout panel.

#### Step 2: Assign a Microsoft Office license to the new user (optional)

The new user account is now available on your tenant, where it is also assigned trial licenses to [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] Enterprise E3 and [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. The user also has an email address at your trial [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] domain. You should consider setting up mail forwarding to make sure the new user will receive signup messages. To set up forwarding:
1. On the **Active users** page, select the name of the new user account. A flyout panel opens showing details about the selected user.
2. Expand the **Mail Settings** heading on the flyout panel. (If you see a message that the mailbox is still being set up, then wait for the setup to complete.)
3. Select the **Edit** link for **Email forwarding**.
4. Turn forwarding on and specify the target email address. Then select **Save**.
5. Close the flyout panel.
6. Sign out of [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and quit your browser.

#### Step 3: Sign the new user up for the Marketing trial

Now the new user needs to sign up for the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial. You can either set this up for them or ask them to do it themselves. Either way, you'll need to approve the new user afterwards. The procedure is as follows:

1. Open a web browser and go to the trial setup URL that was sent to you right after you signed up for the trial.
2. A form opens asking for your email address and phone number. Use the email address for the new user that you just set up in [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)].
3. A page opens to tell you that you already have an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] account, so just select **Sign in**.
4. Sign in using the [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] email address and password that you created for the new user. 
5. A page opens to tell you that you already have a license for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Select **OK, got it**.
6. You now see a list of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organizations that are available on your trial tenant (there may be just one). Select the organization that you want to add the new user to and then select **Join**.
7. A dialog box asks you to choose an app. **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]** is probably already shown and selected, so just select **Continue**.
   A thank-you page opens telling you that a request has been sent to the trial owner (this is the global admin account created when you first set up the trial org).
8. Sign out of [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and quit your browser.

Check the email inbox for the trial global admin. You should find a message telling you that you have a request to join your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] trial. 
1. Select the **Approve** link included in the email.
2. The link opens in your browser, which should now be asking you to sign in to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Sign in using the global admin account.

You should now see an **Approved!** message. The system sends the new user an email that includes a link they can use to sign in to the Dynamics 365 for Marketing trial using the password you chose for them.
The new user is granted most user roles (including admin) in Dynamics 365 for Marketing. If you'd like to restrict access, then see [Assign a security role to a user](manage-users.md#assign-role) for instructions.
