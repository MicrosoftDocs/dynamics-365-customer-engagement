---
title: "Dynamics 365 for Marketing Readme (Known Issues) | MicrosoftDocs"
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.assetid: 78dc5157-cf1d-4e32-ace7-9e71763e7510
author: kamaybac
ms.author: kamaybac
manager: annbe
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Dynamics 365 for Marketing readme

This document provides important, late-breaking information about known issues and workarounds for Dynamics 365 for Marketing.

## Trials

- Trials are subject to the [Dynamics 365 for Marketing trial limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).
- You can't use the sign-up process to add more users to a Marketing trial that is running on a trial tenant without a mailbox set up for the organization admin. Instead, each new user must be added in a specific way. For more information, see [Add more users to a Marketing trial running on a trial tenant](trial-signup.md#add-users).
- You can't sign up using an \@microsoft.com email address. If you are a Microsoft employee and would like to sign up for a trial, start by setting up an Office 365 E3 trial, which will provide you both with a trial tenant (where you can install the Marketing trial) and a new email address that you can use to sign up for the Marketing trial. More information: [Sign up for a free trial](trial-signup.md).

## Configuration, installation, and first-run experience

### Known issues

- Some types of system customizations can interfere with the Dynamics 365 for Marketing setup, resulting in no default contact being created or assigned for your instance. In this case, you must assign one manually. More information: [Default marketing settings](marketing-settings.md#default-marketing-settings) <!--1248465-->
- The setup process can take up to two hours. The process might restart automatically during this time, which can result in multiple success (or failure) notifications being sent to you by email.
- If you have a license for Dynamics 365 for Marketing, but don't have a license for Dynamics 365 for Customer Engagement, any attempt to install the Marketing application will fail. As a temporary workaround, you can install a trial Customer Engagement plan (which will work for 30 days) and then install Marketing. You'll still need to convert your trial into a production instance before the 30 days are up, but this way you can start working in Marketing right away. You can install the trial from your Microsoft 365 admin center as described in [Purchase services](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/use-office-365-admin-center-manage-subscription#purchase-services). <!--- 1183223 -->

### Fixed issues

- You will now always receive an email summarizing the outcome of your setup.<br><del>*First-run experience success and failure emails sometimes aren't delivered.*</del>

## Customer journeys

### Known issues

- Triggers set to react to a specific "link clicked" after an email tile show multiple options for the same link. These triggers might not work correctly because clicks are not always attributed to the correct link. <!--- 759533 -->
- Deactivated contacts won't receive any emails from journeys they were participating in, but they might continue to be included in other actions, such as tasks and workflows. <!--- 759533 -->  
- Insights for journeys, emails, and marketing pages may take up to six hours to display.
- If you stop a live customer journey, then add contacts to the target segment, and restart the journey, those added contacts might receive emails sent by this journey more than once. <!-- 1196442 -->
- If you edit a live customer journey to associate a new email message with an existing email tile, the system may continue to send the previously associated email to recipients. To prevent this, either create a new journey or live-edit the existing email record. <!--- 1345959 -->
- The calendar (date picker) on the scheduler tile's properties on a customer journey might not show the arrows to move the calendar from one month to the next. While these buttons are actually present, the arrows are not visible. <!--- 1450049 -->
- When creating a new customer journey, the default start date and time is set to 2 hours from the system's time, rather than the time according to the timezone of the journey. <!--- 1454828 -->

### Fixed issues

- Users can now check for errors on both the **General** and **Designer** tabs of a customer journey.<br><del>*The “checking for errors” operation triggered in the customer journey’s **General** tab results in a time-out. Users can continue   to “check for errors” from the **Designer** tab.*</del> <!-- 1208237 -->
- The snapshot view generated for a customer journey now displays all tiles.<br><del>*The snapshot view generated for journeys might be missing some tiles.*</del>  <!--- 690797 -->
- On non-English instances, when you save a customer journey using the **Save as template** function, the resulting template now gets saved with its intended language.<br><del>On non-English instances, when you save a customer journey using the **Save as template** function, the resulting template always gets saved with its language set to English. To fix this, go to **Marketing > Customer journey templates**, open the template, and change its **Language** setting to the correct value. When you're creating a new customer journey from a template, you can use the template gallery's **Language** drop-down list to show templates in any selected language.</del> <!-- 1287079 -->

## Segmentation

### Known issues

- Metadata used for building conditions and drop-downs shown on the designer isn't localized for non-English organizations. <!-- 992449 -->
- The **Save** button isn't visible on the command bar after the initial save of the segment. Use the **Save** button in the lower-right corner of the page instead. <!-- 862491 -->
- When trying to estimate the size of a segment where the query doesn't end in a contact, the system displays a server communication error. To correct this error, make sure your segment definition ends with a clause that links to the contact entity as described in [Design profile-based dynamic segments](segments-profile.md). <!-- 1226384 -->
- When you're adding members to a static segment, you can filter the list of available contacts to find the ones you want to add. Sometimes, after adding some filters and selecting **Apply**, the segment definition may stop showing its members. To fix this, save the segment, go back to the segment list, and then reopen it; you should now see the list of members and can continue working on it. <!-- 1282842 -->
- Static segments are limited to a maximum of 1600 members.
- If you create a segment query that includes a lookup field that references an entity of type "systemuser", then your segment won't be created unless the lookup field value is set to the GUID of the related record. For example, if you want to query the owner of a contact record, then the **owner** field is a lookup into the **users** entity (which is of type "systemuser"), so you must set that field to the GUID of the user you want to find with the query. To find the GUID of a user, open the relevant user record and find the value of the "id" parameter in the URL. <!--- 1335786 -->


### Fixed issues

- Segment names can now include spaces.<br><del>*Segment names can't have spaces&mdash;use underscores instead.*</del> <!-- 695837 -->
- Segments can now include lookup field values among their selection criteria.<br><del>*You can't include lookup fields among your segmentation criteria.*</del><!-- 852372 -->  
- Subscription lists now remove unsubscribed contacts from running journeys.<br><del>*Dynamic segments based on subscription marketing lists don't remove unsubscribed contacts from running journeys. The unsubscribe request will be honored in future journeys.*</del>.
- When you go live with a new segment, the **Members** tab now displays correct status messages as the segment is being provisioned.<br><del>*If you go live with a new segment and then open the **Members** tab right away, you'll see a message telling you that the segment doesn't exist (even though it does). Reload the page, or open another tab and come back, to view the correct message (that the segment is being provisioned). Later, once the segment is finished provisioning, you'll see the list of contacts it contains here.*</del> <!-- 1251946 -->

## Email marketing

### Known issues

- Assist-edit is sometimes unavailable for content settings, resulting in inactive assist-edit buttons on this page. This is due to a script not being loaded by the content settings page. To fix the issue, open any email message (which will load the script) and then open the content settings. The script will remain available thereafter until you reload the browser window or close the browser. More information: [Use content settings to set up repositories of standard and required values for email messages](dynamic-email-content.md#content-settings) <!--1406708-->
- The default content-settings record must be live before you can send any marketing emails or view heatmaps on **Insights** pages. Usually, the default content-settings record goes live automatically when your setup is complete, but sometimes this isn't the case. To solve this, set up and publish your default content-settings record manually as described in [Use content settings to set up repositories of standard and required values](dynamic-email-content.md#content-settings).
- Selecting **Stop** on a live email will prevent it from being used in future journeys, but it will continue to function in existing live journeys, which will continue to deliver it.
- If you reuse the same email multiple times (within the same journey or in different journeys) you will see incorrect performance results on its **Insights** pages.
- Many email templates have placeholder images. You should replace these placeholder images with actual images so that marketing emails look professional.
- The email designer requires that you be very careful when entering code for advanced dynamic content. It's easy to produce non-working code. If you want to use this feature, be sure to review the notes given in [How to enter code in the designer](dynamic-email-content.md#enter-code)
- Support for dynamic email content is being expanded to include look-up values, relations, and logical functions like conditionals and for-each loops. We are rolling this capability out gradually, so it may not yet be available on your tenant. For more information about this feature, and how to find out if it's available to you, see [Advanced dynamic content](dynamic-email-content.md#advanced-dynamic-content). Be sure also to read [How to enter advanced dynamic content in the designer](dynamic-email-content.md#enter-code) for important tips on how to mix these dynamic features into your designs.
- If you create an email message with dynamic content that attempts to fetch a single value through a one-to-many database relation, then the system won't know which related record to fetch. As a result, the message will end in an error state when published to the sending service and will therefore never get sent (the error checking mechanism currently doesn't catch this error, which is why you can still publish it). An example of a one-to-many relation is the one between contacts and event registrations because each contact can register for multiple events. To prevent this error from occurring, use a for-each loop to enclose any expressions that reference a one-to-many relationship (this will loop through each related record). More information: [Add dynamic content to email messages](dynamic-email-content.md)
- When you use assist edit to place dynamic content with information about the owner of a contact record, the relationship rendered is incorrect. Instead use the following (and remember also to ensure that the relevant entity is [synced to the marketing insights service](marketing-settings.md#dci-sync)):  
  - If the contact's owner is a user, use:<br/>`contact.contact_systemuser_owninguser.<fieldname>`<br/>(For example, `contact.contact_systemuser_owninguser.firstname` )  
  - If the contact's owner is a team, use:<br/>`contact.contact_team_owningteam.<fieldname>`<br/>(For example, `contact.contact_team_owningteam.emailaddress` )  
     <!-- 1380000 -->
 
### Fixed issues

- When you create a new keyword, the **Save and close** button now correctly returns you to the **Keywords** list.<br><del>*When you save a new keyword for templates or files from a quick-create form, the keyword list isn't displayed, but the record is created successfully.*</del> <!-- 1033440 -->
- Test send works for all organizations. <br><del>For certain organizations that upgraded recently, test send may not work. If you encounter this issue, please contact Microsoft Support. </del><!-- 1267485 -->

## Marketing pages and forms

### Known Issues

- Your marketing forms must include mandatory input fields for each of the fields required by your lead- and contact-matching strategies. If any of the fields required by a matching strategy isn’t present in a form submission, then no lead and/or contact record will be created or updated. More information: [Configure landing pages](marketing-settings.md#config-mkt-pages) and [Design elements for forms](content-blocks-reference.md#form-content-elements) <!--1330191-->
- If you are using the Firefox web browser, then you can’t copy the code generated for embedding a marketing page on an external site. To work around this, use a different browser to accomplish this task. More information: [Embed a marketing form on your own website](embed-forms.md) <!--1392229-->
- When configuring a form on a page, we recommend that you enter a confirmation message or a redirect URL, so users can see that they successfully submitted the form.
- It can take up to a minute after a marketing page goes live before its public link (full page URL) is ready. Visitors might see an error message on the page prior to this.
- Forms submitted over HTTP (not HTTPS) generate interaction records that don't include the contact ID, which means these interactions can't be used in interaction-based segments. If you are hosting a form on an external page (not hosted on a Dynamics 365 marketing page), then make sure your page uses HTTPS.
- Some client-side malware protection tools parse each incoming email, resolve all the links it contains, and then deliver a modified message in which the links have been replaced with their resolved destinations. This process can interfere with the mechanism that Dynamics 365 uses to identify the contact that has clicked on a subscription center link, which means the subscription center won’t work for these contacts. We are working on a fix for this issue.

### Fixed issues

- Marketing pages from sample data go live for all organizations.<br><del>Marketing pages from the sample data might not go live for some organizations (especially on Italian or Japanese localizations). But you can still create new pages and go live with them. </del> <!-- 1156824 -->
- Landing page ID can be added to an existing or new matching strategy.<br><del>The default lead-matching strategy for landing pages matches email address and landing-page ID (msdyncrm_marketingpageid). Currently, a limitation in the UI means that it's not possible to add the landing-page ID to any new or existing lead-matching strategy. Therefore, you shouldn't remove this attribute from the provided default lead-matching strategy unless you are sure you will never use this kind of strategy. If you have removed this attribute and need it back, or if you need to add it to a custom lead-matching strategy, please contact Microsoft Support. More information: [Set matching strategies](marketing-settings.md#matching-strategy)</del> <!-- 1309673 -->

## Reusable content blocks

- Any CSS styles that you include in your reusable content blocks could be overruled by styles in the document where you eventually host the content. If you want to prevent this, design your content blocks with inline styles that include the `!important` attribute.

## Lead scoring and management

### Known issues

- Lead scoring results might take up to one hour to be calculated.
- When you're creating lead scoring rules, drop-down lists might not be localized for non-English languages.

### Fixed issues

- Email sent is now shown in the list of lead scoring conditions.<br><del> When you're creating a lead scoring model and add a condition, the "Email sent" condition isn't shown in the list of options. Use the "Sent" condition instead.</del> <!--- 1289271 -->

## Insights

- Some insights for email delivery (reported by the customer journey, email, and contact entities) appear twice on the **Insights** tab&mdash;once under Stopped in journey and once under Blocked. The affected insights are **Contact lowered consent below threshold** and **Contact lowered external consent below threshold**. Both should appear only under **Stopped in journey**. More information: [Analyze results to gain insights from your marketing activities](insights.md) <!--1396995--> 
- Web interactions registered for an anonymous visitor (on a tracked website, marketing page, marketing form, or redirect URL) don't currently become attributed to a contact record if those visitors later become known contacts. Though these interactions remain anonymous, you can still see them under the related entity (marketing page, website, etc.) and they are leveraged to compute the insights for each record. More information: [Websites](#websites) <!--- 1276305 -->
- Customer journey insights include a count of contacts that stopped their journey midway because the "Contact joined the suppression segment." In the current release,  this count may be unreliable. The suppression segment still works, and the contacts will be stopped correctly on joining it, but some of the contact numbers won't add up due to stopped contacts not getting counted here. <!--- 1331945 -->
- Email insights include a map showing where recipients were when they opened your message. For Gmail addresses, this information will often be inaccurate because of the way that Gmail caches embedded images. Geographical information can also be inaccurate for recipients using a VPN or a widely distributed corporate network.
- Contacts who join the suppression segment of a customer journey while it is running don't get counted as stopped or blocked by the incomplete-journeys insights.  <!--1430509, 1390311 -->
- Feedback-loop counts for email insights don't count recipients who returned feedback using a Gmail account. <!-- 1365343 -->
- Email insights count soft bounce results as successfully delivered, but customer journey results correctly don't count soft bounces as delivered. <!-- 1424358 -->
- Email insights don't count contact-unsubscribed interactions (the value is always shown as zero). However, customer journeys do correctly count  contact-unsubscribed interactions. <!-- 1440493-->

## Event management

### Known issues

- If you disable anonymous registration for the event portal, then customer organizations must create a registerer account using the portal, after which the registerer can register as many attendees from their organization as needed. However, the registerer can't use the portal to create an account using an email address that belongs to a contact already in Dynamics 365. To set up an existing contact as a registerer, create a [portal invitation](../portals/invite-contacts.md) and then send the invitation code to the contact by email.
- Even though surveys are available in the app (such as for emails, journeys, and events), this feature currently has limited functionality. Anonymous surveys can be added to emails but can't serve as triggers in customer journeys. Please contact Microsoft Support for more information.
- Events don't display the total registration count on the "General" tab. To see the registration count, go to the event's "Registration and Attendance" tab. <!--- -->

### Fixed issues

- Events now have sample data.<br><del>*Sample data is no longer available for events. We expect to provide it again in a future update.*</del>
- The event website installed on your Dynamics 365 portal is no longer overwritten after each app update, so any customizations you make to that site will be preserved when you update the app.<br><del>The event portal included with Dynamics 365 for Marketing is intended for demo and testing purposes only. Any customizations that you make to the sample event portal will likely get overwritten the next time you update Dynamics 365 for Marketing.</del>
- Creating a recurring event does not select Monday by default.<br><del>When you create a recurring event with a weekly cadence, the check box for **Monday** is automatically selected both when you first create the event series, and each time you open the event series for editing. Any time you create or edit a weekly series, be sure to clear the **Monday** check box if you don't mean to include it.</del>

## Videos

### Known issues

- When you add a video to a marketing page, the **Designer** tab shows it as a thumbnail image rather than as an embedded video in an iframe. However, the embedded video iframe will still be shown correctly on the live page when you publish it. <!-- Provided as a tip -->

### Fixed issues

- Videos added to Marketing pages or emails will show up as their thumbnails on the **Preview** tab of the designer.<br><del>When you add a video to a marketing page or email, its thumbnail isn't shown on the **Preview** tab of the designer. However, the video is embedded correctly and will be shown in delivered emails and live marketing pages.</del> <!-- 1277775 -->

## Social listening for campaigns

- The [social listening feature](https://docs.microsoft.com/en-us/business-applications-release-notes/October18/dynamics365-marketing/marketing/social-listening-campaigns) currently requires that you set it up manually as described in [Integrate Social Engagement with Dynamics 365](../social-engagement/integrate-social-engagement-dynamics-365.md). We will soon roll out a smoother setup experience fine-tuned for the Marketing app. Keep an eye on the [Dynamics 365 Customer Engagement Team Blog](https://blogs.msdn.microsoft.com/crm/) for updates.
- The social listening control may not show data on some Dynamics 365 instances. If you experience this issue, please contact Microsoft Support. <!--- This is for the UCI FCB that's required to be switched on, and requires a platform upgrade. We can also manually flip this FCB on an org by org basis by updating a DB value -->

## Designer feature protection

- Designer feature protection enables admins to limit access to the HTML tab and/or Litmus previews for content designers. However, the protection only applies to users who have read access to the *Designer Feature Access* entity. Users without this read access will always be able to see the HTML and Litmus features, even if you use designer feature protection to block them. To solve this, make sure all user roles provide read access to the *Designer Feature Access* entity. If you are using the out-of-box user roles supplied with the product, then these should automatically update to include this access when you apply the October 2018 (or later) update, but if you use custom user roles you need to add this access explicitly after updating. More information: [Manage security, users, and teams](../admin/manage-security-users-and-teams.md)

## Websites

- The *websites* feature records all visits to any web page that has a Dynamics 365 for Marketing tracking script on it. Each log entry includes a timestamp and, if possible, links to a known contact. If the visitor isn’t a known contact, then that visit is logged as anonymous. The website tracking script sets a cookie, so the system can group visits into sessions, even for anonymous visits. When a contact submits a landing-page form, the system sets the same cookie (if not present already) and can thereafter match the cookie ID to a contact ID because the landing-page submission will either create or match a contact. Once a visitor is known, all future website visits will be logged with that user's ID. However, previous visits will remain anonymous (the system doesn't back-fill the contact ID to the existing visitor log).

## General

- The following features from the April 2019 release require that your instance has access to the latest Dynamics 365  infrastructure and services: *manage segment memberships from the contact record*, *session-level event registration*, *event-registration QR codes in email*, *portal-optional operation*, and some *segmentation improvements*. We are rolling out the needed infrastructure updates as quickly as possible, and most customers should have them already. If you are running the April 2019 release and require one or more of these features but don't have them available on your instance, please contact Microsoft Support to get your infrastructure updated right away.
- If you have different Dynamics 365 sessions open in other browser windows or tabs, and then open the Marketing app in the same browser, it will authenticate using the same user that you have open in the other sessions. We recommend that you restart the browser each time you need to sign in using a different Dynamics 365 user account.
- Avoid deleting fields and creating them again with the same name but a different field type. This causes issues when syncing those fields with the customer-insights database. Instead, create fields with new names (they can still have the same display name as before if needed). <!--- 1424524 -->
- Avoid deactivating publishable (go-live) records. Instead, change the publishing state (Status reason), and use the **Stop** buttons to manage records that are no longer required. More information: [Go live with publishable entities and track their status](go-live.md)
- Dynamics 365 for Marketing is currently supported only on the following browsers: Microsoft Edge, Google Chrome, and Apple Safari on Mac. More information: [Browser and system requirements](browser-requirements.md)
- Right-to-left (RTL) language support currently has the following limitations: the segmentation designer is usable, but shows its user-interface elements in the wrong order; and the supplied content samples (marketing-page templates, email templates, form templates, and event website) aren't provided in RTL layouts.
