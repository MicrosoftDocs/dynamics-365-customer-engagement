---
title: "Generate, score, and qualify leads (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to work with leads, set up automatic scoring rules, and identify sales-ready prospects in Dynamics 365 for Marketing"
keywords: "lead; lead-scoring rule; grade; qualify; sales ready"
ms.date: 04/01/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d9a600e6-0c1c-48ac-b5dc-8b80c74e9755
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Score and manage leads

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/en-us/videoplayer/embed/ae6596f2-4df4-420e-9635-df776e4e5398" frameborder="0" allowfullscreen=""></iframe></div>

Using [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you can:

- Generate leads manually or automatically by using landing pages.
- Set up automatic lead-scoring models.
- Set lead-scoring grades and the sales-ready threshold.

## Leads and the lead life cycle

A *lead* is an expression of interest in a product or service made within s specific marketing context. The lead life cycle is the journey that a lead takes from creation, through nurturing, and on to opportunity and eventual sale.

When you're doing marketing in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], you'll start with a set of contact records that provide names and contact information about people who you'll be targeting with your marketing initiatives. Some of these contacts might be new or completely unknown to you, whereas others are well-known customers who have a history of purchases and interactions with your organization.

When a contact submits a marketing page that is set up to create contacts and leads, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] generates a new contact record (or finds an existing record, if a matching contact exists), and then generates a lead (or finds an existing lead, if a matching lead exists) and links the lead and contact records together as required. If a matching lead already exists, a lead scoring rule might automatically increase the score of the lead in response to the submission. The lead represents an expressed interest in that specific campaign or initiative (this is called the *marketing context* of the lead). Some contacts might have several lead records activated at the same time, each tracking a different level of interest in a different campaign or product. Even a well-known contact with a long history of purchases might get a new lead created when they interact with a newer campaign.

After a single interaction, a new lead is usually still considered *unqualified*, which means that you don't have enough confidence in it to ask a salesperson to engage. Marketers typically put contacts with leads like these into a *nurturing campaign*, which seeks to build interest by supplying additional information and new offers.

Each lead has a score, and each time the associated contact interacts with an initiative in that lead's marketing context, it increases the lead score until it reaches a certain threshold, at which time it's considered marketing-qualified (sales-ready). At that point, the lead is sent to a salesperson, who decides whether to accept the lead. After the lead is accepted by sales, the lead might go on to become a sales-qualified lead, then converted to an opportunity and, finally, become a closed sale. Or, the salesperson might decide that the lead isn't ready and might reject the lead or recycle it by sending it back to marketing. Other leads might eventually get marked as lost, but the contact will remain in your database to be included in future marketing campaigns.

> [!IMPORTANT]
> Automatic lead scoring only works for leads that are associated with a contact. Scoring fails for leads that don't have a contact associated with them. Also, segments in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can only include contacts, not leads, which means that you can only address marketing emails to contacts.
> 
> Your landing pages will typically either create a lead/contact pair when they create a new contact, or associate new leads with existing contacts when they're available. But when you create a lead manually, you must also associate it with a contact manually to enable lead scoring.

## Lead generation

There are two ways to create a lead: manual and automatic.

- To view, create, or edit a lead manually, go to **Marketing** &gt; **Customers** &gt; **Leads**. This opens a standard list view, which you can use to search, sort, filter, create, and delete your leads. Open any lead to view its details. Select **New** to create a new one.

- To generate leads automatically, create a marketing page that is configured to generate leads (and possibly contacts too). When a contact submits a landing page such as this, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] matches incoming form data against existing contacts and leads. It creates new contacts and leads as needed, and links them together. Auto-generated leads store information about the context where they were created, including the marketing page, marketing form, customer journey, and email message associated with it.

## Lead scoring

After a lead exists, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] can start scoring it based on demographic data, firmographic data, and contact interactions. Scoring occurs automatically according to rules that you establish as lead-scoring models.

## Create, view, and manage your lead-scoring models

Lead-scoring models provide rules for how a lead's score will automatically increase or decrease based on specific activities and interactions, demographic information, and over time. The model also establishes a schedule of grades that characterize ranges of scores in plain language (such as hot, warm, and cold), and sets a specific score threshold as "sales ready", which means that the lead can now be forwarded to a salesperson.

A typical lead-scoring model would increase a lead's score slightly in response to a single email open or website visit, moderately in response to an email click or landing-page submission, and significantly in response to an event registration or attendance. The model could also stop counting interactions that happened some time ago, effectively reducing a lead's score as it ages. It might also increase or decrease a lead score based on information about the associated contact or company, such as location, purchase history, company size, industry, job title, and more.

You can create as many scoring models as you want. If you have more than one model, all leads will be scored according to each model and you'll be able to see the score and grade for each of them.

To view, edit, and create lead-scoring models, go to **Marketing** &gt; **Lead Management** &gt; **Lead Scoring Models**. This opens a standard list view, where you can create, delete, search, sort, or filter items in the list. Select any item in the list to open it, or select **New** to create a new one.

![The lead-scoring model designer](media/lead-score-designer.png "The lead-scoring model designer")

You'll spend most of your time working on the **Design** tab, which opens when you first open or create the model. This is where you define the model's logic by dragging tiles from the **Toolbox** tab to the canvas to construct one or more condition/action tile pairs. Each pair starts with a **Condition** tile, which establishes a rule (such as email clicked) and ends with an **Action**, which defines how the score should be adjusted when the condition is met. Your model can include any number of condition/action pairs.

The scoring-model canvas is similar to the customer-journey canvas. Add tiles by dragging from the **Toolbox** tab. Select a tile and open the **Properties** tab to make settings for that tile. Use the toolbar above the canvas to cut, copy, paste, and delete a selected tile; you can also add a tile and take a snapshot from here.

### Set up a condition

The condition tile is a compound tile, which includes both parent and child tiles. When you add a condition, both the parent and one child are created. Use the expand/collapse button at the lower-right corner of the tile to show or hide the child tiles.

![An expanded condition tile with one child](media/lead-score-condition.png "An expanded condition tile with one child")

The parent condition tile just gives the condition group a name. Select the parent and open the **Properties** tab to assign the name. You can assign as many child conditions as you need by dragging additional condition tiles onto the parent.

> [!NOTE]
> All conditions belonging to the same parent are combined using an AND operator, which means that all sibling conditions must evaluate to TRUE for the attached action to be triggered.

The logic for the condition is contained in the child tile(s). Choose a child condition tile and open the **Properties** tab to establish the logic.

![Condition tile settings](media/lead-score-logic.png "Condition tile settings")

Set up the logic for a condition tile by making the following settings:

- **Display Name**: Shows the name for the tile, as shown on the canvas.
- **Entity**: Choose a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] entity to monitor or check for the condition. For example, choose **EmailClicked** to look for records where a contact has clicked a link in an email.
- **Frequency**: Choose how often the condition should be triggered. Choose **Each** to score on each occurrence (such as to increase the score on each email click). Choose **At least** to score just once (such as to increase the score on the first email click, but ignore subsequent ones).
- **Date Range**: Enter a date before which scorable events won't be counted. For example, set this to a year to ignore all email interactions that occurred more than a year ago. This can result in scores going down over time as interactions age.
- **New Expression**: Select this button to add a new expression to the condition. The additional expression further tests the condition based on stored data. For example, you could add an expression for "City = New York", which would modify the condition so that only email clicks made by contacts in New York City would trigger the condition. You can add as many extra expressions as you like to create complex conditions.

    > [!NOTE]
    > All expressions belonging to the same condition are combined using an AND operator, which means that all expressions must evaluate to TRUE for the overall condition to be true.

There are two categories of conditions:

- *Fixed rules* are based on fixed demographic or firmographic data found in lead or contact records.
- *Behavior rules* are based on interactions like email clicked, event registered, or website visited.

### Set up an action

The action tile that comes after a condition tile controls how a lead's score will be modified when the condition is met. To set the action, select (or add) an action tile after a condition tile, then open the **Properties** tab, where you can set the score to either increase or decrease by any integer value.

### View all conditions at once as text

The canvas provides an easy, graphical way to assemble your scoring rules, but it leaves most settings hidden until you open a tile's **Properties**. To get a quick overview of all your logic, set the **View** drop-down list (above the canvas) to **Text**. This shows you a compact, text-based view of your rules, expressed in a way that's similar to an actual database query.

![Text view of a lead-scoring model](media/lead-score-text-view.png "Text view of a lead-scoring model")

### Establish grades and the sales-ready score

The main reason for scoring leads is to provide a way to identify your best leads and to decide when a lead should be forwarded to a salesperson for more attention. Therefore, you'll nearly always set a sales-ready threshold for each lead-scoring model. You can also set up a schedule of grades as a way to offer an interpretation of the score (such as cold, warm, or hot) as it progresses toward sales-ready.

When a score reaches the sales-ready threshold, a plug-in automatically sets the sales-ready flag on the lead to *True. If a lead is scored by multiple models, the flag is set as soon as any model reaches the threshold. This triggers a workflow that automatically moves the lead to the sales-acceptance stage of the lead lifecycle. You can customize this workflow as needed.

The grades and sales-ready score apply to the entire model, regardless of how many conditions it contains. To set them, open the **Grades** tab next to the canvas.

![Grades and sales-ready score](media/lead-score-grades.png "Grades and sales-ready score")

Enter an integer in the **Sales Ready Score** field to set the sales-ready score.

To add an additional grade, select **New**, which adds a new section to the tab, where you can enter a grade name and the score range where it applies. Grade ranges must be continuous and non-overlapping.

<a name="traversals"></a>

## Create advanced lead scoring conditions by using traversals

When you are setting up a condition tile for lead scoring, you can set up the **Entity** you are testing to include traversals across interactions and profiles by using a _dot notation_, where each hop is separated by a period. For example, you could start with an interaction such as _EmailClicked_ and traverse to the associated _Contact_ profile, and then test for values from the contact profile. Here's an example of how to set this up:

1. Open the **Properties** for a **Condition** tile. Then set the **Entity** to **EmailClicked**.  
    ![Choose the first entity in the hop](media/lead-scoring-hop-example-1.png "Choose the first entity in the hop")

1. In the **Entity** field, type a period after the **EmailClicked** entity you just added to open a new drop-down list that shows the various types of hops you can make from here. Choose **EmailClicked_contact** to hop to the contact profile.  
    ![Add a period to create a hop to a second entity](media/lead-scoring-hop-example-2.png "Add a period to create a hop to a second entity")

1. Now you can add **Expressions** to specify values that come from the contact record associated with each email click. For example, you might only want to score on clicks for contacts that live in Chicago.  
    ![Add a condition for the final entity in the chain](media/lead-scoring-hop-example-3.png "Add a condition for the final entity in the chain")

> [!NOTE]
> You can establish up to five hops by using this technique.

Here are a few more examples of how to use hops to create useful conditions:

* **Lead.lead&#95;contact&#95;parentcontactid**: Lets you score leads associated with contacts who have particular properties (such as contacts who have a Microsoft email address&#8212;where _Email | contains | @microsoft.com_).
* **Lead.lead&#95;contact&#95;parentcontactid.contact&#95;account&#95;parentcustomerid**: Lets you score leads associated with contacts who belong to accounts with particular properties (such as accounts where _Number of employees | > | 500_).

### See also

[Set up lead scoring](set-up-lead-scoring.md)  
[Register contacts' engagement](register-engagement.md)  
[Manage customer information](manage-customer-information.md)  
[Accessibility and keyboard shortcuts](designer-shortcuts.md)
