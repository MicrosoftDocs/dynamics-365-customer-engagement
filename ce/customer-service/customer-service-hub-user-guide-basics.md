---
title: Learn the basics of the Customer Service Hub app | Microsoft Docs
description: Learn the basics of the Customer Service Hub for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/23/2019
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Learn the basics of the Customer Service Hub
  
The Customer Service Hub’s intuitive interface brings together vital information in one place, so you can focus on the things that matter.  

## Customer Service Hub application requirements  
 Here’s a list of browsers and mobile versions that are supported by the Customer Service Hub:  
  
- **Browsers** 
    - Google Chrome
    - Microsoft Edge (supported on Windows 10)
    - Apple Safari 11
    - Internet Explorer 11

- **Mobile**
    - iOS 10 - Tablet & Phone
    - Android - Tablet + Phone (Android 6 and 7)
    - Windows 10 

## Open the Customer Service Hub
The Customer Service Hub app is available to use on a desktop browser and on a mobile device for managing knowledge articles and case management. You can open the Customer Service Hub in the following ways:  

> [!NOTE]
>  These options are available only to users with the Customer Service app access role , System Administrator role, or System Customizer role. 

**Desktop browser**
  
- In the Common Data Service platform, go to **Settings** > **Application** > **My Apps** >  **Customer Service Hub**.   

   ![open-csh](media/open-csh.png "Open the Customer Service Hub")
 
  
- In the Dynamics 365 Customer Service sitemap, navigate to the app switcher and then select **Customer Service Hub**.

  ![open-csh-sitemap](media/open-csh-sitemap.png "Customer Service Hub sitemap")
  
**Mobile device**

To access the Customer Service Hub app on a mobile device:

- Install the Dynamics 365 Customer Service mobile app. 
  
  To install the Dynamics 365 Customer Service mobile app, see [Install Dynamics 365 for phones and tablets](../mobile-app/install-dynamics-365-for-phones-and-tablets.md)
- From the MyApps page, select **Customer Service Hub**.

   ![choose-on-mobile](media/ChooseAnApp_1.png "Customer Service Hub on mobile")


## Work with case management record types, dashboards, and tools  
 In the Customer Service Hub, you will find everything you need to easily manage customer service at your organization:  
  
-  Dashboards  
-  Activities: Email, Task, Appointment, Phone Call, Social Activity  
-  Accounts  
-  Contacts 
-  Social Profiles 
-  Cases 
-  Queues  
-  Knowledge Articles

The Customer Service Hub comes with an enhanced sitemap to enable easy navigation of the interface. To learn more, see [Understand the sitemap navigation](#understand-the-sitemap-navigation).
  
> [!NOTE]
> The navigation bar for the Customer Service Hub is different from the navigation bar in the Common Data Service platform. </br> Any record types that are enabled for mobile are also available for use in the Customer Service Hub. However, these records are read-only.  


## Understand the sitemap navigation
  
1. Select the sitemap icon ![Sitemap](media/sitemap-icon.png). Select **Service**, and then select an entity record type.
  
    ![navigate recods](channel-integration-framework\media\add-site-to-any-entity.png "Navigate records")
  
    Now you can add a site to any entity (for example “account”) when you select a record type from the menu, such as Accounts, Contacts, or Cases, you’ll see a list of corresponding customer records (also known as **Entity grid**). 

 	To view recently opened records, select the down-arrow next to the record type in the sitemap.

    Here is what each entity record type is used for:

    - **Dashboards** collect all your most important data in one place. You can select from multiple dashboards as per your role.
    - **Activities** help you keep track of tasks, email messages, appointments, phone calls and much more.
    - **Accounts** are the companies you do business with.
    - **Contacts** help you manage and store information about the customers you work with.
    - **Social Profiles** let you track a contact's presence in social media.
    - **Cases** help you create and track your customer requests and issues.
    - **Queues** keep a track of cases waiting for you to work on.
    - **Knowledge Articles** capture your customer’s questions, issues, feedback, and resolutions, so that other service reps can benefit from them.

2. Select **...** to go to **Training** and access the documentation site to view the **Help Center**. 
3. You can also access **Service Management** from the sitemap. Service Management lets you define all the customer service admin settings from the Customer Service Hub sitemap.  Select **...** to go to **Service Management**. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Service Manager Guide (Customer Service Hub and Customer Service app)](service-manager-guide.md).
4. Select **Favorites and Recent** button ![recent-button](media/fav-and-recent.png)  to see recently viewed records, or to see views that have been pinned as favorites.

   For a mobile device, the sitemap is displayed as illustrated in the following image:

   ![mobile-sitemap](media/mobile-sitemap.png "Customer Service Hub sitemap on mobile")


## Open the default dashboard for a record type
When you’re viewing the list of records for a specific record type, select **Open Dashboards** in the command bar to switch to the default dashboard for that record type. 

To return to the list of records, select **Open Views** in the command bar.
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use interactive dashboards to effectively manage service cases](customer-service-hub-user-guide-dashboard.md)
  
 
## Navigate through records and pages  
  
-   When you're viewing a record, select and expand **Open Record Set** to navigate to other records. A side panel opens where you can view other records. You can directly select the records from the panel and view the details of the  record.
 
      ![record-set](media/v9-record-set.png "Record set")

> [!NOTE]
> The option Open Record Set will not be available on devices with comparatively smaller screen sizes.
  
-   To go the previous page in the Customer Service Hub, click the browser’s **Back** button. 
   
   
## Quickly create new records
  
- To create records quickly by filling in only the most basic information, select the **New** button ![Create button](../customer-service/media/quick-create-button.png "Create button") given on the nav bar.

  > [!TIP]
  > On a mobile device, from the nav bar, tap ![ellipsis](media/ellipsis.png) and then tap **Quick Create Menu**.


## Email a link  
You can email links to records so your colleagues can quickly find these records by selecting the links. To email links to records, select one or more records in the list, and then on the command bar, select **Email a link**. The default email client opens with the links to these records. The recipients will see all content in the records for which they have permission.  

## Know your forms
Forms are designed to help you quickly handle important customer service tasks and complete actions from a single place.

Understand the different components of a form below:
  
### Business processes
 In the Customer Service Hub, forms for cases and knowledge articles include a process bar (also called a business process flow), which appears when you save the record for the first time. 
 
When you select a process stage on the process bar, you'll see the steps to take to complete that stage. A flag on a stage indicates the stage you’re currently on. When you select an active stage, you can see the **Next Stage** button move to the next stage in the process.  

The stages in the business process flow are displayed in floating mode, or docked mode. Stages can  be aligned in a vertical layout, instead of horizontal, which makes it easier to see what steps are required to move forward. You can also choose to include an optional step in the business process flow and define criteria to trigger it.

![business-process-flow](media/business-process-flow.png "Business process flows")
  
If there is more than one process to follow, you can switch between them by selecting **Process** > **Switch Process** on the command bar, and then selecting the process you want to use.  Or you can choose to abandon the process if it no longer applies.
  
 When a business process flow based on multiple entities is applied to a case or a knowledge article, the following limitations apply:  
  
-   The business process flow based on multiple entities isn't displayed on the form.  
  
-   The **Switch Process** option only shows business process flows that are based on a single entity.  
  
-   If there are only multi-entity business process flows for an entity, the **Switch Process** option isn't available.  

### Tabs  
 A tab is a group of sections on a page. Each case form is composed of one or more tabs. By default, the **Summary** tab shows information about the customer, interactions with the customer, and other related records. You can select different tabs to enter or see other miscellaneous details of a record.  
  
For example, here’s a view of how the tabs appear on the case form:
  
![case-form-tabs](media/v9-case-form-tabs.png "Case form tabs")
  
 This table lists the default tabs for each record type and the information that they show for a particular record.  
  
|Record type|Default tabs|  
|-----------------|------------------|  
|Case|**Summary**. Includes the customer card, Timeline, and the Related section.<br />   **Details**. Tracks Case details, additional details, and social response details of the case. <br />**Case Relationships**. Shows a Merged Cases and Child Cases list. You can add a new child case to the current case from the Child Cases list. It also shows a list of knowledge articles associated with the case.<br />**SLA**. Shows the related SLA KPI Instance records that are created for each SLA KPI that is tracked for the case. <br />**Related**. Shows related entities like Knowledge Base records and Connections.|
|Account|**Summary**. Includes the customer card, Timeline, and the Related section.<br />**Details**. Tracks additional details like company profile, marketing details, contact preferences, and billing and shipping.<br />**Related**. Shows related common entities.| 
|Contact|**Summary**. Includes the customer card, Timeline, and the Related section.<br />**Details**. Tracks additional details like personal information, marketing details, contact preferences, and billing and shipping. <br />**Related**. Shows related common entities.| 
|Activities|Activity forms shows a tab called Task for the respective activity and a Related tab for common entities. |  
|Knowledge Articles|**Content**. Lets you write and edit the content for the article.<br />**Summary**. Tracks basic settings, Timeline, publishing settings, and related information.<br />**Analytics**. Shows the number of views, feedback, and a list of cases using the article.<br />**Related**. Shows related common entities.|  
|Social Profiles|**Social Profile**. Captures general information, and social profile details along with related social profiles.<br />**Related**. Shows related common entities.|  

### Contact card  
 See a complete view of your customer’s touch points in the Contact card. This card is available in the **General Information** section of the **Summary** tab.  
  
![contact-card](media/contact-card.png "Contact card")

 You can add a picture to the account or contact record in the Common Data Service platform, and it will appear on this card. You can make calls to customers from the Contact card using Skype for Business – IP telephony.
  
 For account records, the card shows contact details for the primary contact associated with the account. For contact records, the card appears if the contact is the customer value on the case form.  

### Timeline  
 See a combined view of your customer’s interactions across various channels, such as phone, email, or even social activities in the Timeline. The Timeline also shows any related notes or system posts.  The Timeline makes collaboration with other users easy and efficient.

> [!Note]
> This section is pre-release documentation and is subject to change.

The Customer Service Hub comes with an enhanced timeline that shows you all customer interactions arranged in a single stream. 
Managing activities in the timeline wall will be faster and more responsive with improvements to data viewability and usability.

  ![Timeline shows customer activities across channels](../customer-service/media/v9-case-form-timeline.png "Timeline shows customer activities across channels")

  1. Add info and activities
  2. Filter
  3. More commands
  4. Activity icons

The timeline section is available on the **Summary** tab for account, contact, case records, and for knowledge articles, and it shows the following:
- Activity
  - Appointment
  - Email
  - Phone Call
  - Task
- Note
- Post

> [!Note]
> The activities mentioned above are out-of-the-box. If your administrator or system customizer has configured other activities, then those will appear. 

You can create, edit, and delete an activity, note, post, and other interactions from the timeline itself. Additionally, you can filter and sort the interactions. In the timeline area, you can see three actions: **Add info and activities**, **Open filter pane**, and **More commands**. Use these options to add, filter, and sort the interactions on the timeline.

- **Add info and activities:** Select the **+** icon in the timeline area to quickly open an activity type page to create and save. The activity type you created appears in the timeline.

- **Filter the activities:** With the help of text and visual filters, you can filter by activity types in the timeline. You can also view the items from the previous day or week, and you can filter the interactions using the filter icon in the timeline area. To learn more, see [Filter activities on the timeline](#filter-activities-on-the-timeline)

- **More commands:** The timeline provides the options to refresh so you see the updated list of activities and sort the timeline interactions. Select the ellipsis (**...**) in the timeline to refresh and sort the timeline by choosing one of the two: **Sort newer to older** and **Sort older to newer**.

  ![timeline-ellipsis](media/timeline-ellipsis.png "Timeline ellipsis to filter activities")

#### **Take a note**
You can select the **Enter a note** field in the timeline and specify a title and message. You can also add attachments to your notes.

![Timeline notes and attachment](media/timeline-attachment.png "Timeline notes and attachment")

You can do the following:

- Identify the key activities with simple icons.
- Quick access to the command bar to perform common actions on an activity with ease.
- Filter activities on the timeline with multiple filter options.
- View and manage email conversation threads on the timeline with ease.
- Expand and collapse activities in the timeline with ease.

#### **Identify the activities with icons**
The timeline shows a simple icon next to the activity making it easy for you to identify the type of activity.

  ![Timeline activity icons](../customer-service/media/activity-icons.png "Timeline activity icons")

  1. Task
  2. Phone Call
  3. Posts
  4. Email
  5. Note
  6. Appointment

#### **Access command bar to perform actions**
When you hover the cursor on an activity, the command bar appears with the options specific to the activity, such as marking an activity complete, assigning it to others, adding it to a queue, converting it to a case, liking a post, replying to a post, editing a note, or deleting the activity.

  ![Timeline command bar options](../customer-service/media/timeline-options1.png "Timeline command bar options")
  ![Timeline command bar options](../customer-service/media/timeline-options2.png "Timeline command bar options")
  ![Timeline command bar options](../customer-service/media/timeline-options3.png "Timeline command bar options")
  ![Timeline command bar options](../customer-service/media/timeline-options4.png "Timeline command bar options")

#### **Filter activities on the timeline**
Quickly filter the activities with multiple filter options to see what matters to you. The filter is available for the activity types that are present in timeline. That is, in the image shown, all are activity types are present in the timeline so the filter displays the activity types and the count of those activity types. 

When you select the filter icon, you can see the **Filter by** menu where you can filter the items based on the following categories.

  | Category | Sub-category |
  |-----------------------|-----------------------|
  | Record type | <ul> <li> Notes </li> <li> Posts </li> <li> Activities </li> </ul> |
  | Activity type | <ul> <li> Appointment </li> <li> Email </li> <li> Phone Call </li> <li> Task</li> </ul> |
  | Activity status | <ul> <li> Active </li> <li> Active and overdue </li> <li> Closed </li> </ul> |
  | Activity due date (active) | <ul> <li> Next 30 days </li> <li> Next 7 days </li> <li> Next 24 hours </li> <li> Last 24 hours </li> <li> Last 7 days </li> <li> Last 30 days </li> </ul> |
  | Modified date | <ul> <li> Last 24 hours </li> <li> Last 7 days </li> <li> Last 30 days </li> </ul> |

  ![Timeline activity filter](../customer-service/media/timeline-filter2.png "Timeline activity filter") ![Timeline activity filter](../customer-service/media/timeline-filter5.png "Timeline activity filter")

#### **View and manage email conversations**
You can easily set email messages to show as conversation threads on the timeline, significantly reducing usability (scroll and clicks) when managing email activities.

#### **Expand and collapse timeline activities**
Select an activity from the timeline to expand and view.

  ![Timeline expand and collapse activity](../customer-service/media/timeline-expand-collapse.png "Timeline expand and collapse activity")

#### Configure Timeline section for your users

 To learn more about configuration, see [Set up timeline section (control)](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control) and [FAQs for timeline control](https://docs.microsoft.com/powerapps/maker/model-driven-apps/faqs-timeline-control).

### Related section  
In the **Related** section (also known as Reference panel), use the tabs to see related records for the current record. This section is enabled by default for account, contact, case, and knowledge article records. Your customizer can add this section for all entities (including custom entities) that are enabled for interactive experience. The reference panel is also available in model-driven apps, for information, see  [Reference Panel in model-driven apps ](https://docs.microsoft.com/powerapps/user/navigation#reference-panel).

By default, the first tab in the Related section of a case record shows the **Recent Cases and Entitlements** for the current case record you’re working on. 
  
![reference-panel](media/reference-panel.png "Reference panel")

The second tab in the Related section of a case record is the **Knowledge Base search**. Knowledge Base search lets you search for the knowledge articles related to a specific record. It also lets you view automatic suggestions. You can filter the search results to display articles that are Published, Draft, or Approved. For more information, see [Search for Knowledge articles](search-knowledge-articles-csh.md). 
  

The third tab in the Related section of a case record displays **Similar Cases**. Select **...** on a record to follow or unfollow the case, and explore other options. 

![similar-cases](media/similar-cases.png "Similar cases in Reference panel")

 Watch this video to learn more about the Reference Panel in the Customer Service Hub:

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/videoplayer/embed/d8224c3f-6e20-4b8e-9d0d-b0f5602c7708" frameborder="0" allowfullscreen=""></iframe></div>

> [!NOTE]
> You can configure rules that help you view similar cases based on automatic suggestions. For more information, see [Use advanced similarity rules to view similar case suggestions](suggest-similar-cases-for-a-case.md).

Similarly,

- For **Accounts** records, you can view **Contacts**, **Recent Opportunities**, **Recent Cases**, and **Entitlements** in the Related section.
- For **Contacts** records, the Related section displays **Recent Opportunities**, **Recent Cases**, and **Entitlements**. 
- For **Knowledge articles** records, select an article and go to the **Summary** tab to view the **Related Information** panel. Here you can view **Related versions**, **Related translations**, **Related categories**, **Related articles**, and **Related products** for an article.

> [!NOTE]
> Your system administrator or customizer can choose if Related section should be included in a form. They can also decide on what related data should be displayed in the section for each form.


#### Reference Panel reflow
The Customer Service Hub is available to use on a desktop browser, and on a mobile device. Depending on the zoom level and the resolution of the system on which you are accessing the hub interface, the Reference panel adjusts the tabs and records for an optimum experience.

For example, on a browser, if you zoom in to about 100% or more, the tabs get docked on the top of the panel.

![reference-panel-zoomin](media/rp-zoomin.png "Reference panel reflow")

Similarly, if you zoom out to about 60-70%, the records appear in grid form.

![reference-panel-zoomout](media/rp-grid-zoomout.png "Reference panel reflow")

## Understand Activities

Activities are the tasks that you or your team perform while interacting with customers. An activity is any action which can be entered on a calendar and has time dimensions (start time, stop time, due date, and duration) that help determine when the action occurred or is planned to occur.

For example, you can make a record to track a phone call with a customer, or list an appointment scheduled with a customer to discuss a certain issue. You can create activities for yourself, or assign them to other service reps.

In Dynamics 365 Customer Service, the following activities are supported:
- Email
- Task
- Appointment
- Phone Call
- Social Activity

> [!NOTE]
> You can create and edit emails in the Customer Service Hub app on a desktop browser. However, on a mobile device email is read-only in the Hub app.

#### Open Activities view
In the Customer Service Hub sitemap, select **Service** > **Activities**. The **My Activities** view is displayed. 

![activities-email](media/activities-csh-email.png "Activities view")

- Select ![quick-create-activity](media/quick-create-button.png) in the nav bar to go to **Activities** to quickly add a new activity.

- Select the **My Activities** drop-down to switch between activity views.

- Select the  **Due** drop-down to see the list of activities that are due in coming time or are already overdue.

- Explore the command bar options to create a new activity like new **Task**, **Email**, **Appointment**, or **Phone call**.
  
  For example: To create a new email, select **Email** from the command bar.  The New Email activity form is displayed.
  
- Select **...** in the command bar and go to **Open Dashboards** to directly open activity dashboard.

- To view the status of an activity, click the activity record and see bottom-left in the activity form. 

## Work with Queues

Use queues to organize, prioritize, and monitor the progress of your work. In Dynamics 365 Customer Service, queues are containers used to store anything that needs to be completed or requires an action, for example completing a task or closing a case. To know more about creating and managing queues, see [Create and manage queues](set-up-queues-manage-activities-cases.md).

**Open Queues view**

In the Customer Service Hub sitemap, select **Service** > **Queues**. The queues view is displayed.

![queues-view](media/queues-view.png "Queues view")

- Use the drop-down lists to switch between the views and the various queues.
- Select a record in the queues view to:
    - **Edit** the record
    - **Route** the record
    - **Pick** the record. It will be assigned to you and will be moved to your queue.
    - **Release** the record. It will be assigned back to the queue owner for other's to pick up.

To know how to add a case to a queues, see [Add a case to a queue](customer-service-hub-user-guide-case-sla.md#add-a-case-to-a-queue).


### See also

[Create and design forms for Customer Service Hub](create-design-forms-customer-service-hub.md)

[Track your cases efficiently and act on them quickly](customer-service-hub-user-guide-case-sla.md)
