---
title: "Preview features (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Learn what preview features are, and how to activate and use them in Dynamics 365 for Marketing"
keywords: preview
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: d27cf07f-3cef-4fdb-8d12-ffea28ed6f50
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

# Activate and use preview features for April 2019

From time to time, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] makes new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] features available as *preview features*, which you can enable and use if you want to get familiar with upcoming features before they're officially released and fully supported. Read this topic to learn about which preview features are currently available, how to activate them, and how to use them.

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

## Enable preview features

Most preview features aren't installed or enabled by default. A system administrator must explicitly enable and install them before they will become available to any instance.

> [!NOTE]
> If you already enabled the preview features that were available for the February 2019 update and would now like to try the new preview features released in March 2019, then all you need to do is [update your instance](apply-updates.md). You don't need to opt-in again as described in this section.

> [!NOTE]
> If you already have a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] environment (including a trial), but don't yet have [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installed on it, and you'd like to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] with the preview features already enabled, then you can do both at once by first enabling the preview on your instance (as described here) and then installing  [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

To enable the preview features:

1. Sign in to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] (or any app on your tenant) as an administrator.

1. Go to your [Power platform admin center](https://admin.powerplatform.microsoft.com/) (this link will bring you there).

1. Select **Environments** in the side navigator. A list of environments on your tenant opens. (Environments are also sometimes called *instances* or *organizations*.)

1. Select the environment where you want to enable the preview.
    > [!CAUTION]
    > We highly recommend that you only enable preview features on a sandbox or trial environment, not on a production environment. You can [copy a production instance](manage-marketing-instances.md) to a sandbox if you want to test on your exact configuration, and sandbox environments can be reset, backed up, and restored as you test features without impacting your production users.

1. Find the **Updates** section of the page, and then select the **Manage** link at the top of this section.

    ![Location of the Updates section](media/preview-enable-1.png "Location of the Updates section")

    > [!NOTE]
    > If the **Manage** link isn't present, and it says **On** under **April 2019 update**, then you've already enabled the preview for this environment. But you might still need to install the features, so skip ahead to step 8 to make sure.

1. The **April 2019 update** flyout slides in from the side of the page. Select the **Activate now** button at the bottom of the flyout.

1. The **Turn on April 2019 update?** dialog box opens. To confirm that you want to enable the preview features for your selected environment, enter the environment name in the field provided here and then select **Confirm**.

    ![The enable-preview flyout and dialog](media/preview-enable-2.png "The enable-preview flyout and dialog")

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Go to the **Applications** tab of the admin center to see a list of applications you have installed.  
    ![Open the Applications tab](media/update-app-tab.png "Open the Applications tab")

    The list shows a row marked **Dynamics 365 Marketing Application** for each entitlement (license) you have for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Free entitlements show a **Status** of **Not configured**. Installed entitlements show a **Status** of **Configured** and include the name of the environment where they are installed at the end of their application name.

1. From the list on the **Applications** tab, select the **Dynamics 365 Marketing Application** where you want to enable the preview, and then choose **Manage** from the side panel.
    - If you're adding the preview to an existing [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installation, then choose the configured application that includes the name of the environment you just enabled for the preview.
    - If you're installing [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] for the first time, then choose an unconfigured entitlement. Later, when asked by the setup wizard, choose the environment you just enabled for the preview.

1. The setup wizard launches. Follow the instructions on your screen to update or install on your selected environment. For more information about the setup wizard, see [Run the setup wizard](purchase-setup.md).

See the remaining sections of this topic for details about how to find and use the preview features.

## Preview: Provide personalized marketing page content

As with marketing emails, you can create marketing pages that display content that's personalized for known contacts. The solution makes use of the following techniques:

- **Known contacts are identified by a cookie set on their browser**  
The required cookie is set in a user's browser when they open any [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] landing page, embedded form, or subscription center. The cookie might initially be anonymous but gets linked to a contact record when the contact submits a landing page with valid contact details or opens a subscription center using a personalized link sent to them in email.
- **JavaScript is used to fetch values from the relevant contact record to the marketing page**  
[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] generates the code you must add to your page to connect to the database and fetch the field values, but you must modify this with the specific field names you want to use, and also write your own JavaScript to make use of those values on the page. You might display contact values directly, or use them programmatically to modify page content, layout, and more.
- **Data access is restricted to explicitly white-listed fields from the contact entity**  
For security, the solution will only provide those field values that you specifically configure to make available to personalized landing pages.
- **Contacts must accept form prefilling to see personalized marketing page content**  
For privacy, the solution only allows personalized content to be shown to contacts whose contact record has the _allow-prefill_ flag set. This same flag enables landing pages to display forms that are prefilled with values from the contact record of a known contact (identified by the same cookie). Contacts can set or clear their allow-prefill flag themselves using a subscription center or landing page form, provided your form includes a "remember me" setting.
- **Use the**  **personalized**  **pages**  **entity to establish the white list and generate the JavaScript**  
Go to **Marketing** > **Marketing content** > **Personalized pages** to identify which contact fields to make available and generate the code for bringing those values onto the page.

### Limitations of the preview version

The preview version of this feature has a few limitations that we expect to remove when the feature becomes generally available. These include:

- You can only include personalization on pages created by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and hosted on the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal. The feature won't currently work on hosted forms.
- You can't live-edit page-personalization records in the preview version. You must stop each record before you can edit it, and then go live again when you're done.
- On the contact level, personalized pages use the existing form-prefill flag to enable/disable personalized-page features for each contact. In the final release, we may introduce a separate flag that applies to personalized pages only.

### Set up page personalization

To prepare the page-personalization feature, you must establish the white list of contact fields and generate the JavaScript code you'll need to import field values onto your page. You'll do this by working with _personalized page_ records.

Personalized pages are go-live entities, which means that a record must be live for its fields white list to take effect.

To set up one or more personalized page records:

1. Go to **Marketing** > **Marketing content** > **Personalized pages**.

1. A list of existing personalized page records opens. Do one of the following:
   - If you want to edit a record that's  already shown here, select it to open it and start editing. If the record already shows a **Status reason** of **Live** , then select **Stop** in the command bar to unlock it for editing.
   - If no records are shown, or if you want to create a new one, then select **New** in the command bar to create a new one. Then enter   **Name** for the record and select **Save** in the command bar to create the record and show all available settings

    ![A new personalized pages record](media/page-personalization-new.png "A new personalized pages record")

1. The **Fields** table shows a list of contact fields already white listed by this record (if any). To add a new filed to the white list:
    - Select the **New personalized page field** button next to the **Fields** table heading. (If you don't see the button, then expand the **More commands** menu (ellipsis button) and select **New personalized page field** from there.)
    - The **New personalized page field** page opens. Identify the field you want to white list by making the following settings:
      - **Personalized page** : This shows the name of the personalized page record you are editing, and to which you will add the new field. Don't change this.
      - **Name** : Select the name of the field you want to white list from this drop-down list. All available fields from the contact entity are available here.
      - **Owner** : This defaults to your user account. Usually you should leave it.
    - Select **Save &amp; Close** on the command bar. This returns you to the personalized page record you were editing, where you should now see your new field added to the **Fields** table.

1. If you want to edit or remove a field from the white list, select the target field to highlight it, then do one of the following:
    - To remove the selected field, expand the **More commands** menu (ellipsis button) and select **Delete personalized page field**.
    - To edit the selected field, select the **Edit** button next to the **Fields** table heading or from the **More commands** (ellipsis) menu (depending on your screen size).
    - On smaller screens, each listed field shows a **More commands** menu that you can open to **Edit** or **Delete** that field directly.

1. When you're done setting up the **Fields** list, select **Go Live** on the command bar to activate the record. The fields listed in that record are now available for use on marketing pages. Also, the **JavaScript code** field now shows the generated code that you must add to each page you want to personalize, as described in the next section.

### Add personalization to a marketing page

After you've set up a personalized-pages record to whitelist all the fields you need and generate the required JavaScript, as described in the previous section, do the following to add personalized features to your page:

1. Go to **Marketing** > **Marketing content** > **Personalized pages** and open the record that white lists all the contact fields you need for your page.

1. Make a note of the exact spelling of each field in the **Fields** list.

1. Select all the text in the **JavaScript code** field and copy it to your clipboard.

1. Go to **Marketing** > **Internet marketing** > **Marketing pages** and open (or create) the page where you want to add personalization.

1. Go to the **Content** > **HTML** tab for your selected marketing page.

1. Paste the JavaScript code into the `<head>` section of the HTML. Your pasted code should look something like this:

    ```javascript
    <script src="https://mktdplp901cdn.azureedge.net/public/1.35.1022.0/static/js/loader.js"></script>
    <script>window.msdyncrm_personalizedpage = {
      id:"438d3652-e339-e911-a9d2-000d3a147cc6",
      success: function(data) {
       // TODO: do something with data like
       // var firstname = data.Data["firstname"];
       // alert(firstname);
      },
      error: function() {
      }
    };</script>
    ```

1. The provided JavaScript includes some sample code in comments (which start with //). For each contact field that you want to use on your page, create an uncommented code line of the following form:

    ```javascript
    var <LocalFieldName> = data.Data["<RealFieldName>"]
    ```

    Where:
    - *&lt;LocalFieldName&gt;* is the name you'll use to refer to the field using JavaScript on the marketing page. You can choose any name you like, but usually you'll pick one that matches the read field name.
    - *&lt;RealFieldName&gt;* is the name of the field as defined in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. This must match one of the fields you white listed earlier, as listed in the Fields table of the page-personalization record.

    For example:

    ```javascript
    var first = data.Data["firstname"]
    ```

1. Each contact record that you enabled in the `<head>` is now available to JavaScript on the page. Use standard JavaScript techniques to reference and use the values.

### Test your page personalization

As mentioned in the introduction to this section, page personalization requires that a contact is known and allows prefilling of marketing pages. To test your page personalization, do the following:

1. Set up page personalization and create your personalized page as described earlier in this section.
2. Open ([or create](create-deploy-marketing-pages.md)) a marketing page that's live and running on your instance and that includes a [marketing form](marketing-forms.md) with the following:
    - An [field design element](content-blocks-reference.md#form-content-elements) for each of the values you want to test on your personalized page.
    - A [remember-me design element](content-blocks-reference.md#form-content-elements) (which creates a checkbox that enables/disables prefilling and page personalization for the submitting contact)
3. Fill out all the fields on the registration form and be sure to mark the "remember me" check box. When you submit the form, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] will set a cookie in your browser, which enables the system to identify you the next time you open a marketing page.
4. Allow about 30 seconds for the system to process the submission and create a new contact record.
5. Open your personalized marketing page and confirm the personalization features work as expected.

## Preview: Expanded support for externally hosted forms

The current version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] already lets you create marketing forms that you can [embed on your own, external website](embed-forms.md), but with a few limitations. We're working towards removing these limitations to enable you to create fully functional marketing pages that can run on your own, external website or CMS system. The following elements of this functionality are now available as preview features:

- Enable prefill on embedded forms
- Run a subscription center as an embedded form
- Use external forms for inbound customer journeys
- Create customer journey triggers that react to external form visits and submissions

### Enable prefilling on hosted forms

Form prefilling enables your forms to include prefilled values for known contacts. Prefilling makes your forms easier for contacts to use and can therefore help to increase your submission rates. The feature uses cookies to identify contacts that have previously submitted a form or opened a subscription center using a personalized link sent in email.

Because form prefilling requires the form to fetch contact values from your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database, a few extra security measures are in place to help protect contacts' privacy. This means that contacts need to opt-in for form prefilling and that you must authenticate each domain where you'll use the form. The solution only allows prefilled values to be shown to contacts whose contact record has the _allow-prefill_ flag set. Contacts can set or clear their allow-prefill flag themselves using a landing any page form, provided the form includes the setting. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users can also edit a contact record directly to edit this setting for that contact.

To create a form with prefilling that you can embed on an external website:

1. Set up domain authentication for the external domain (website) where you will host your form and be sure to mark the **Enable prefilled forms** check box. You don't need to also enable email authentication on that domain, but you can. For instructions, see [Authenticate your domains](marketing-settings.md#authenticate-your-domains) (note that the **Enable prefilled forms check** box isn't mentioned in that topic yet because this is preview functionality, but other than that, follow the procedure provided there to generate your authentication key and register it with DNS for your external domain).

    ![Enable prefilling on an authenticated domain](media/authenticated-domains-prefill.png "Enable prefilling on an authenticated domain")

1. Create a form with the required fields and design elements as described in [Create, view, and manage marketing forms](marketing-forms.md).

1. Enable prefilling for the form as described in [Enable prefilling for forms](form-prefill.md).

1. Save the form and then go to the **Form hosting** tab (first available on save) to set up a _form page_ for it as described in [Embed a marketing form on your own website](embed-forms.md). Note that you don't need to setup a whitelist on the **Form hosting** tab (as described in the linked topic) because you've already authenticated your external site, which provides even better security than the whitelist provided here.

1. As described in [Embed a marketing form on your own website](embed-forms.md), copy the JavaScript code generated for the new form page and paste it onto a web page or CMS page for your website.

### Embed a subscription center as a hosted form

You can embed a subscription center form on an external site just as you can a standard landing page form. The only difference is that you must set the **Form type** to **subscription center**. Then authenticate your external domain, set up the form, and embed the generated form code on your page as described in the previous section.

### Reference hosted forms in emails and customer journeys

Once you have a hosted form set up, you're ready to start using it in your marketing emails and customer journeys.

#### Link to a hosted form from an email message

Unlike local landing pages, there is no [design element](content-blocks-reference.md) dedicated to external forms. Therefore, use either a button element or a standard text link to link to your embedded form using its page URL from your webserver.

#### Use hosted forms with journey triggers

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] now includes a _marketing form_ tile for customer journeys. It works just like the marketing page tile, both to enable customer journey triggers to react to form visits and submissions, and to create inbound campaigns (as described in the next section).

To set up a journey that invites contacts to visit an externally hosted form and then reacts to form visits and/or submissions:

1. Create and go live with a [marketing email message](prepare-marketing-emails.md) that includes a link to the page where you are hosting the form.

1. Create a customer journey as usual.

1. Start the journey with a segment that targets the contacts you want to invite to visit your landing page.

1. At the location where you want the journey to send the message, add a **Marketing email message** tile that references your message.

1. Drag a **Marketing form** tile from the **Toolbox** onto your **Marketing email** message tile to add the form as a child of that message. Then follow this message tile with a **Trigger** tile.

    ![Marketing-form and trigger tiles](media/journey-host-form-trigger1.png "Marketing-form and trigger tiles")

1. Expand the Marketing email message tile to see the **Marketing form** tile you just added to it. Select the **Marketing form** tile, open the **Properties** panel, and configure it to reference the form record that created the JavaScript (form page) you have embedded on your external site.

    ![Assign a form page to the form tile](media/journey-host-form-trigger2.png "Assign a form page to the form tile")

1. Select the **Trigger** tile and open its **Properties** panel.

1. Select **New** next to the **Set rules** heading in the trigger properties.

    ![Trigger properties](media/journey-host-form-trigger3.png "Trigger properties")

1. A new rule is added to the trigger. Set the **Source** to the name of the **Marketing form** tile that you added to the **Marketing email message** tile, and set the **Condition** to **Marketing form visited** (to trigger when a contact loads the form) or to **Marketing form contact registered** (to trigger when a contact submits the form).

    ![Conditions for a form-based trigger](media/journey-host-form-trigger4.png "Conditions for a form-based trigger")

1. Continue designing your customer journey as required.

1. Save and go live.

### Use hosted forms with inbound campaigns

You can create an inbound campaign by placing a **Marketing page** tile at the start of a journey, and then configure the tile to reference the form record that created the JavaScript (form page) you have embedded on your external site. This will cause each contact that submits the form to be added to the journey, just as though they had joined a segment targeted by the journey. You could already [do something similar for marketing pages hosted on a Dynamics 365 portal](create-inbound-customer-journey.md), but now you can also do it with an externally hosted marketing forms.

![Inbound campaign from a hosted form](media/journey-host-form-trigger5.png "Inbound campaign from a hosted form")

<a name="social-posting"></a>

## Preview: Social posting

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can schedule and post messages directly to your organization's accounts on social media sites. In the current preview version, only Twitter and Facebook are supported, but we expect to add more social media channels when this feature becomes generally available.

<a name="config-social"></a>

### Configure your social media accounts

Before you can start posting to social media, an administrator must sign in and connect to the social accounts where users want to post and schedule messages.

To add and authenticate a social media account:

1. Go to **Settings** > **Advanced Settings** > **Marketing settings** > **Social configuration**. A list view opens showing your existing social media accounts (if any).
1. Select **New** on the command bar.
1. A new social configuration record opens. Make the following settings:
    - **Name**: Enter a name that you and others will easily recognize. Choose a name that gives a good idea what type of channel it is what type of content should be posted there, such as "Contoso Electronics Twitter."
    - **Social channel**: Choose the social-media site you want to connect to (such as Twitter).
1. Select **Sign in** on the command bar.
1. Follow the instructions on your screen to sign in to your social media account and allow [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to post through this account.

If your sign-in times out, or if the password changes on one of your accounts, you can update an account by doing the following:

1. Go to **Settings** > **Advanced Settings** > **Marketing settings** > **Social configuration**.
1. Select a social media configuration from the list.
1. Select **Sign in** on the command bar.
1. Follow the instructions on your screen to update your sign-in details.

You can delete a social configuration at any time to prevent [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] from posting through that account from now on.

### Schedule and post messages on social media

Use the **Social posts** entity to author and schedule your posts. You can post from any social-media account that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], as described in the previous section.

In the current preview version, only Twitter is supported, but we expect to add more social media channels when this feature becomes generally available.

To schedule and post a message to one of your social-media channels:

1. **Go to Marketing** > **Marketing execution** > **Social Posts**.
1. A calendar opens, showing all scheduled and previously posted messages. Do one of the following:
    - To schedule a post using the calendar, choose a calendar view (month, day or week), select a day or time slot to highlight it, and then select again (click or press enter) and choose **New item** from the context menu. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with marketing calendars](marketing-calendar.md)
    - To schedule a post using date pickers, or to send it right away, select **New** on the command bar.
1. A new social post record is created. Make the following settings:
    - **Name**: Enter an internal name for the post. This name will be shown on the calendar, but won't appear in the post itself.
    - **Social channel**: Choose the social channel on which to post your message. Each of the channels currently supported by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is listed here. (In the current release, only Twitter is available.)
    - **Posting from**: Select the specific account through which to post your message. This drop-down list shows each account for the selected **Social channel** that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Configure your social media accounts](#config-social)
    - **Select scheduling**: Choose how to schedule your post by selecting one of the following:
        - **Post now**: Your message will be posted immediately when you save the record, and will be shown on the calendar for the current date and time.
        - **Schedule**: Choose a specific date and time to post the message. If you started by choosing a date and time on the calendar, then this option is preselected.
        - **Schedule later**: Choose this if you want to save the messages without posting or scheduling it. You can come back later to either choose a schedule or post immediately by selecting one of the other options here.
    - **Posted time**: If you choose to schedule your message, then specify the date and time to post it here. If you started by choosing a date and time on the calendar, then those values are already shown here.

    > [!IMPORTANT]
    > The dates and times for the posting schedule use the time zone configured in your personal settings. To view or edit your time zone, open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and then select **Personalization settings**.

1. Enter the content of your message in the large text field, exactly as you want it to appear in your social-media post.
1. Select **Save** to post or schedule your message according to your settings.

### Reschedule or cancel a post

You can reschedule or cancel any post that hasn't been sent yet. Just find and select it on the calendar to open the record, and then edit the schedule or select **Delete** on the command bar, as needed.

Posts that were already sent are read-only, so you can't change or reschedule them, but you can remove them from the calendar if you want.

## Preview: Detailed quota reporting

The preview features an expanded **Quota limits** page, which now tracks the number of marketing contacts you have licensed and the number you are actually using. As before, this page also monitors your quotas of email messages and Litmus inbox previews.

To see how much of each quota you've used, go to **Settings** > **Advanced settings** > **Other settings** > **Quota limits**.

The following quotas are tracked here:

- **Marketing email messages**: Shows the total number of email messages you can still send this month, and the total number you have sent. Your email quota is equal to ten times your marketing contacts quota.
- **Litmus inbox previews**: Shows the total number of Litmus email previews (inbox previews) users at your organization can still request this month, and the total number that have been used. This quota is included with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] license and is shared by all users from your organization. Individual users can get more previews by setting up a private (not shared) account with Litmus, but individual accounts aren't tracked here. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use the advanced inbox preview feature](prepare-marketing-emails.md#inbox-preview)
- **Marketing contacts**: Shows the total number of *marketing contacts* that you can have in your database according to your current [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] subscription. Marketing contacts only include those that you engage with marketing activities such as emails, landing pages, forms, LinkedIn integration, events, and surveys. Contacts that you never engage in marketing activities won't be counted as part of this quota. For more information about marketing contacts and how they are counted, see [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md#how-licensed) and the [Administration and setup FAQ](setup-troubleshooting.md#licensing)
- **Total contacts**: Shows the total number of all contacts that are stored in your database. No quota applies here, so this is just for your reference (for example, so you can easily compare your number of total contacts to your number of marketing contacts)

You can read the following information about each type of quota listed here:

- **Total purchased**: Shows the total number of each quota that you have purchased for the current cycle.
- **Total used by this org.**: Shows the total number of each quota that you've used for the current [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization (also known as an *instance*).
- **Total used by tenant**: Shows the total number of each quota that you've used for the tenant (which may include several [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organizations). Some quotas apply per organization, while others apply at the tenant level. 
- **Percentage used by tenant**: Shows a percentage of how much of each quota you've already used for the current cycle.
- **Days remaining in current cycle**: For quotas that apply over time, this value shows how many days are left until the quota gets reset.
- **Status**: Indicates whether or not you've used up your quota for the current cycle.

## Preview support and feedback

If you wish to report an issue with a preview feature, please [open a support ticket](https://docs.microsoft.com/power-platform/admin/get-help-support) and include the following tags in the **Issue title** of your ticket:

- For marketing-contacts monitoring, please include: [PREVIEW][MCM]
- For social posting, please include: [PREVIEW][SOCIAL]
