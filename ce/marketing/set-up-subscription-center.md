---
title: "Set up a subscription center (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to create subscription lists and add them to a subscription center in Dynamics 365 for Marketing"
keywords: tutorial; subscription center; static list; subscription list; marketing page; page
ms.date: 05/24/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 21159fd7-50cc-4879-884c-888bc0d6b457
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

# Set up subscription lists and subscription centers

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A subscription center is a marketing page that known contacts can use to manage their communication preferences and contact details with your organization.

All marketing email messages that you create by using [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must include a link to a subscription center, and they will fail the error check if you try to go live with a message that lacks this link. There are two good reasons for requiring a subscription center link in all marketing email messages:

- **Legal requirements**: Many countries/regions have laws that require all marketing email messages to include an unsubscribe link.
- **Deliverability**: Spam filters and internet reputation monitors can identify marketing email messages, and might remove those that don't include an unsubscribe link.

All subscription centers include a **do not email** check box. When a contact chooses this option, the **do not bulk email** flag gets set on his or her contact record and [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] will never send any marketing email messages to that contact. Optionally, your subscription center can present several additional subscription options, such as a list of available newsletters. By presenting several different mailing lists on your subscription center, you gain an opportunity to learn more about your contacts' specific interests while also giving contacts more options beyond the legally required "do not bulk email" option.

Each subscription list exists as a static marketing list in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], while **do not bulk email** is an explicit attribute of the contact entity. That means that **do not bulk email** overrules subscription list memberships, but it also means that list memberships will be reactivated if a contact later clears **do not bulk email**.

The only way a contact can access a subscription center is by clicking a link sent to them in email. Email links are always personalized for the recipient, which means that [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] always knows which contact has requested the subscription center and therefore populates it with that contact's current details and subscriptions. Note that you can also add subscription lists to standard marketing pages, which enables inbound (previously unknown) contacts to sign up for one or more mailing lists at the same time they register.

## How and where to publish your subscription centers

A good subscription center is vital for any organization doing email marketing. As mentioned previously, the feature is required by law in many jurisdictions, and you must link to it from every marketing email you send. You can run as many subscription centers as you like, for example to support various brands or product families, but you must always have at least one. Each subscription center can offer as many different subscription lists as you like, but each subscription center must provide an option for contacts to opt-out of all marketing emails.

<a name="default-center"></a>

### The default subscription center

A default subscription center is provided with every [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance. This default page runs natively on the service fabric for your instance and doesn't require a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]
portal or external website. This is to ensure that all organizations running [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can provide this essential feature, even if they don't have a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]
portal or external website.

To find, customize, and view the default subscription center:

1. Go to **Marketing** > **Internet marketing** > **Marketing pages** to open a list of available marketing pages.
1. Find the page called **Default Marketing Page** in the list. This is the default subscription center.
1. Select the **Default Marketing Page** to open it.
1. Go to the **Summary** tab and look at the **Full page URL**. Note that this URL uses the same domain as your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance. Select the globe button here to open the page in a new browser tab.
1. The page is already live by default. If you'd like to customize it, select **Edit** in the command bar and then work with it just as you would with any other marketing page. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] 
1. Select **Save** when you are done customizing. The page automatically publishes your changes and returns to the live state.

> [!IMPORTANT]
> Never delete the default subscription center page! This is the only page that is published on the service fabric rather than on a portal or external site. There is no way to create a new page that is published in this way, so if you delete the default subscription center, you'll need to create an alternative on your portal or external site.

As with all marketing pages, the subscription form on the default marketing page is a marketing form that is defined separately and placed on the page using a form design element. You can edit the form directly and don't need to open the page to do so. To find, customize, and view the default subscription form:

1. Go to **Marketing** > **Internet marketing** > **Marketing forms** to open a list of available marketing forms.
1. Find the form called **Default Subscription Center Form** in the list. This is the default subscription form.
1. Select the **Default Subscription Center Form** to open it.
1. The form is already live by default. If you'd like to customize it, select **Edit** in the command bar and then work with it just as you would with any other marketing form.
1. Select **Save** when you are done customizing. The form automatically publishes your changes and returns to the live state. All pages that use the form will now automatically use your updated version.

### Custom or additional subscription centers

You can publish subscription centers as a native marketing page running on a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]
 portal, or set up a marketing form that's embedded on an external site. You can use either of these types of pages as your primary subscription center if you prefer not to use the default one.

<a name="create-subscription-list"></a>

## Create a subscription list

Subscription lists are based on the standard (static) marketing lists feature of [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. To create one:

1. Go to **Marketing** > **Customers** > **Marketing lists**.

1. You now see a list of existing marketing lists, if any. On the toolbar, select **New** to create a new list.

1. The **New Marketing List** page opens. Make the following settings (at minimum):
   - **Name**: Enter a descriptive name
   - **List type**: Set to **Static**.
   - **Targeted at**: Set to **Contact**.
   - **Locked**: Leave set to **No**.

    ![How to configure a list as a subscription list](media/subscription-list-example.png "How to configure a list as a subscription list")

1. On the command bar, select **Save** to save your new list.

1. After saving, the **Subscription** field becomes unlocked (provided you've set the **List type** to **Static** and **Targeted at** to **Contact**). Set **Subscription** to **Yes**.

1. Select **Save** on the command bar to save your new list as a subscription list.

## Add a subscription list to a subscription form

Now that you have a subscription list available, you can add it to a subscription form. The procedure is nearly the same as when you add other types of input fields to a form.

1. Go to **Marketing** &gt; **Internet Marketing** &gt; **Marketing Forms**.

1. You now see a list of forms. On the command bar, select **New** to create a new one.

    > [!TIP]
    > You could instead edit an existing form by choosing it from the list, but for this exercise we'll describe how to create a new one. Note that if you edit an existing form, your edits will affect all marketing pages that use that form because forms are imported by reference, not copied to the page like template content.

1. The **Marketing form templates** dialog box opens, which helps you find and choose a template to help get started quickly. Select the **Filter** button near the top of the dialog box.

1. The **Filter** panel opens. It's important to select a template of the correct type (subscription center), so start by filtering the template list by setting the **Form type** to **subscription center**. Then select the close button of the **Filter** panel to view the results.

    ![Use the filter to find subscription center templates in the gallery](media/form-template-subcenter.png "Use the filter to find subscription center templates in the gallery")

1. Select one of the subscription forms now shown in the gallery. We're using the **heraklion** template as the example in this procedure, so choose that if it's available. Then choose **Select**.

1. Your selected template is now copied to your new form design.  
    ![Edit the heading inserted by the form template](media/form-headings-from-template.png "Edit the heading inserted by the form template")

    As you can see, the template has already provided the following:
   - A basic contact-information form that includes several typical fields
   - A **Do not email** check box (which is required for all subscription forms)
   - A **Submit** button (which is required for all forms)
   - Two headings with placeholder text surrounded with square brackets.

    Work directly on the canvas to select each of the placeholder headings (including the brackets) and replace them with actual headings (for example, **Update your contact information** and **Newsletter subscriptions**).

    > [!TIP]
    > Many of the supplied templates for emails, pages, and forms employ this convention of using square brackets to mark instructional placeholder text. They also typically use pseudo-Latin ("lorem ipsum") text as a placeholder for body text, and sometimes example text for headlines, but these don't use square brackets because the text isn't instructional.

1. On the **Toolbox** tab, scroll down until you find the **Subscription lists** heading. You should see the subscription list that you just made listed here, plus any others that were already in your system. Drag it from the **Toolbox** to the space under the **Newsletter subscriptions** heading.  
    ![Add a subscription list to the form](media/from-add-subscription-list.png "Add a subscription list to the form")

    > [!TIP]
    > Only forms of type *subscription center* show subscription lists in the **Toolbox**.

1. On the command bar, select **Save** to save your new form.

1. On the command bar, select **Go live** publish the form, which makes it available for use on marketing pages.

## Create a subscription center marketing page

Go to **Marketing** &gt; **Internet Marketing** &gt; **Marketing Pages** and create a subscription center page by using the same basic procedure that you used to create a landing page, but be sure to do the following:

1. Make sure the page **Type** is **Subscription Center**, or choose a marketing page template where **Type** is **Subscription Center**.

1. Include a **Form** element that references the subscription form you just made. Configure the form's **Submission behavior** with relevant messages and a **Redirect URL**.

1. Enter values for all other required fields (**Name** and **Partial URL**).

1. Select **Check for Errors** and address any issues reported.

1. Select **Go Live**.

For a detailed walkthrough of how to create a marketing page, see [Create a landing page with a form](create-landing-page.md).

## Identify a subscription center in content settings

Content settings hold common values that you can place into an email message as dynamic text by using assist-edit (or by typing the correct code). You can create as many content-settings records as you need, and you must assign one to each customer journey. Because of this architecture, you can use the same email message in several customer journeys, but the subscription center link (and other content settings) included in the message can be different for each journey.

To work with content settings records, go to **Marketing** &gt; **Templates** &gt; **Content Settings**. This brings you to a list of current content settings. As usual, you can edit any listed record or select **New** on the command bar to create a new one.

> [!TIP]
> Like email messages and customer journeys, content settings must be published to the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] email marketing service (by selecting **Go Live**). If you need to edit a live content-settings record, choose **Edit** on the toolbar after opening the record, make your changes, and then select **Save**; on save, it automatically publishes your changes and returns to the live state.

Each field shown here (besides the **Name** and **Default** setting) can be referenced dynamically in your email messages. The two fields, **Address Main** and **Subscription Center** must be referenced in all marketing emails, so they are likewise required here.

![Content-settings settings](media/content-settings-general.png "Content settings")

To specify a subscription center in the content settings:

1. Select the **Subscription Center** field.

1. Select the assist-edit button **&lt;/&gt;** for the **Subscription Center** field.

1. The assist-edit dialog opens. Select the **Static** radio button.    
    ![Assist-edit with Static selected](media/assist-edit-subcenter-1.png "Assist-edit with Static selected")

1. From the **Select an option** combo box, select **Marketing page**.

1. From the **Choose a record** combo box, select the name of the subscription center page you want to use. If you have a large number of pages, you can enter some text here to filter the list, which can make the page you want easier to find. You have now identified the marketing-page record that will be your subscription center for this content-setting record.

1. Select **Next** to continue.

1. Select the **Property** radio button. .    
    ![Choose a specific marketing page](media/assist-edit-subcenter-2.png "Choose a specific marketing page") 

    Note the code shown at the bottom of the dialog&mdash;this is the actual expression that you have built based on your choices so far

1. From the **Select field** combo box, select **FullPageUrl**. This is the field from the marketing-page entity that holds the URL for the marketing-page record you identified on the previous page. 

1. Select **OK** to add the dynamic expression you have built to your content settings.

    > [!TIP]
    > The expression you just created by using assist-edit is of the form:
    >
    > **{{*EntityName*(*EntityID*).*AttributeName*}}**
    >
    > This expression evaluates to the value of the named attribute (in this case, the URL of a marketing page) from a record of the named entity and ID.
    >
    > Using similar techniques, you can also reference a **Forward to a Friend** page and you can even construct **Address Main** by grabbing field values from an account record.

1. Make other content settings as needed. When you are done, **Save**, **Check for Errors**, and then **Go Live**.

For more information about content settings and the assist-edit tool, see [Add dynamic content to email messages](dynamic-email-content.md).

## Identify the content settings to use in a customer journey

As mentioned, content settings are defined on the customer journey level, and apply to all email messages sent by that journey. To view and edit the content settings applied to a journey:

1. Go to **Marketing** &gt; **Marketing Execution** &gt; **Customer Journeys**.

1. Find your journey in the list, or select **New** in the command bar to create a new one.

1. Go to the **General** page of the customer journey record.  
    ![Where to set content settings for a journey](media/journey-general-content-settings.png "Where to set content settings for a journey")

1. Use the **Content Settings** field to choose the Content Setting record that applies to the current journey.

## Include a subscription center link in a marketing email

To add a subscription center link to a marketing email:

1. While working in a text element, add some link text (such as **manage subscriptions**) at an appropriate place.

1. Select the anchor text, and then select the **Link** button ![The link button](media/email-link-button.png "The Link button") from the floating toolbar, which opens the **Link** dialog box.    
      ![The email Link dialog](media/email-link-dialog.png "The email Link dialog box")  

1. Select the assist-edit button for the **Link** field. In the assist-edit dialog, select **Contextual** and then **ContentSettings** on the first page. Select **Next** and then pick **Property** and **msdyncrm_subscriptioncenter** on the second page. Select **OK** to place the expression `{{msdyncrm_contentsettings.msdyncrm_subscriptioncenter}}` into the **Link** field. 

1. Select **OK** to create the link.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create a marketing email and go live](create-marketing-email.md)

<a name="test-sub-center"></a>

## Test your subscription center

To test your subscription center, you must send yourself a subscription-center link in a live email from a live customer journey. The subscription center won't work correctly if you open its URL directly, or click a link sent in a test message.

Subscription centers only work when they "know" who they are talking to. This enables the subscription center to display existing contact information in editable fields (like name and email), and also to indicate which of the available subscription lists the viewer already belongs to. The only way most people will be able to open the subscription center is by selecting a link sent to them in a marketing email from a customer journey, and links such as these include an ID that lets the subscription center know which contact has requested the page. (In fact, all links in marketing emails include an ID that's linked to both the contact and the message, which enables the system to report which link each contact has selected in each message.)

If you open a subscription center by opening its URL directly (or by using  a link sent in a test message), the page will load, but the form will be empty, all subscription lists will be cleared, and you won't be able to submit it. To fully test your subscription center, set up a simple customer journey that targets a single contact record with your email address and sends out a simple marketing email that links to your subscription center (similar to the journey presented in the previous section, but be sure to use a very limited segment). When you receive the message, select the subscription center link and test its features.

### See also

[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[Create a simple customer journey](create-simple-customer-journey.md)  
[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Working with segments](segmentation-lists-subscriptions.md)  
[How Dynamics 365 for Marketing uses cookies](cookies.md)
