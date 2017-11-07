---
title: "Set up lead scoring models in Dynamics 365 for Marketing | Microsoft Docs"
description: "A tutorial for how to set up lead-scoring models and read lead scores in Dynamics 365 for Marketing"
keywords: "tutorial; leads; lead scoring; lead scoring model"
ms.date: 11/07/2017
ms.service: crm-online
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e892a409-1e68-491f-8992-1b281ba4a5a3
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Set up automatic lead generation and scoring

A big part of marketing has to do with finding new leads, qualifying them, and then sending sales-ready leads to salespeople. To help you identify the hottest leads, [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] scores each one based on criteria including each lead’s demographic details and interaction record. A lead that meets your target demographic profile and has interacted with your marketing materials (for example, by opening emails, registering for downloads, browsing your website, and/or attending an event) will probably get a high score, provided you’ve set up your scoring model correctly.

> [!TIP] You can create any number of lead-scoring models, with each lead being scored according to each model. That means that if you have several models, then each lead will also have several scores. A lead becomes sales ready only after all models produce a sales-ready score for that lead.

To create a lead scoring model:

1. Go to **Marketing &gt; Lead Management &gt; Lead Scoring Model**. This takes you to a list of existing models. Choose **New** from the command bar.

1. The **New Lead Scoring Model** page opens, with the **Design** tab shown. This designer is similar to other designers in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] for marketing. It lets you build scoring models by creating a collection of condition/action tile pairs, where the **Condition** tile establishes a condition (such as “email opened”) and the **Action** tile establishes how the score should change when the condition is met (such as, “add 50 points”).  
    ![Add a condition tile to the model](media/scoring-add-condition.png "Add a condition tile to the model")

    Drag a **Condition** tile from the **Components** tab to the first position on the canvas.

1. When you drop the tile, it stays selected and the **Properties** tab opens to show its settings. In this case, the only setting is a name for the tile. You’re going to create a condition that looks at the city where a lead is living, so set the **Display Name** to “City”.  
    ![Set a display name for the condition tile](media/scoring-condition-name.png "Set a display name for the condition tile")

1. Expand the new **Condition** tile by choosing the expansion button in its bottom-right corner. Here you can see that your new **Condition** tile already has a child **Condition** tile. The parent **Condition** tile just establishes a name for the stack while the child establishes a logical condition. If the child condition resolves to true, then the lead score will be updated as specified in the **Action** tile that follows (you’ll add that in a few minutes).  
    ![Expand the condition and select its child tile](media/scoring-child-condition.png "Expand the condition and select its child tile")  

    Select the child **Condition** tile, open the **Properties** tab and enter a **Display Name** for the tile. You’re going to increase the score for leads from London, so name it something like “City of London”.

    > [!TIP] You can add more child conditions by dragging more **Condition** tiles onto the same parent. If you do this, then all child conditions are combined with an AND operator, which means that *all* of them must evaluate to true for the following **Action** to be applied.

1. Click in the **Entity** field to place the insertion point. [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] fetches a list of scorable entities (which can take a few seconds) and displays them as a drop-down list. The list includes all relevant entities that can be related to a lead record, plus the lead entity itself.  
    ![Choose an entity for the condition](media/scoring-condition-entity.png "Choose an entity for the condition")  

    You are looking for the name of the city where the lead works, which is recorded on the lead itself, so choose the **Lead** entity here.

1. After you’ve chosen an **Entity**, an **Expression** box is added that provides choices appropriate for that entity. Use the **Field**, **Operator**, and **Value** fields here to establish an expression that evaluates to true where “City = London”.  
    ![Set an expression for the condition](media/scoring-condition-expression.png "Set an expression for the condition")

    > [!TIP] You can add more expressions here by choosing **+ New Expression**.

1. Drag an **Action** tile from the **Components** tab to the space immediately to the right of the **Condition** tile you just set up.  
    ![Add an action tile](media/scoring-add-action.png "Add an action tile")

1. When you drop the tile, it stays selected and the **Properties** tab opens to show its settings. This is where you set how a lead’s score is changed when the **Condition** resolves to true.  
    ![Action tile properties](media/scoring-action-properties.png "Action tile properties")

    Set **Score Update** to +70. The rule will now give 70 points to any lead working in London.

1. Using a process like the one you used to create the first rule, add a new rule below the first one and set it to give +40 points to leads living in England (check the Leads entity where Country/Region = England).  
    ![Add a second rule to the model](media/scoring-second-rule.png "Add a second rule to the model")

    > [!TIP] When your model includes several rules, like this one does, then each rule can affect the lead score independently. For example, the model you built so far will increase a lead score by 110 points for leads that live in London, England. Likewise, leads from Manchester, England will get +40 points and leads from London, Ohio will get +70 points.

1. Open the **Grades** tab in the right column.  
    ![Set the sales-ready score](media/scoring-salesready.png "Set the sales-ready score")

    You can use **Grades** to establish a schedule of grades associated with each of several score ranges, but the most important setting here is the **Sales Ready Score**. When a lead reaches this score, the system will consider it sales ready (marketing qualified) and therefore ready to be forwarded to a salesperson for further attention. Let’s suppose that any lead located in London, England is sales ready, so set this to 100.

    > [!TIP] You can add any number of additional grades to help classify a lead according to its score (such as 0-25=Cold, 26-60=Warm, 61-100=Hot). Choose **+ New** on the **Grades** tab to add and define each required grade.

1. Like customer journeys, landing pages, and email messages, your lead scoring rule must go live before it has any effect. Do the following to finish the model:
    - Choose **Save** from the command bar to save your model.
    - Choose **Check for Errors** from the command bar, then read the results and fix any problems reported.
    - Choose **Go Live** from the command bar to activate the model. [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] runs a final error check and then updates the **Status Reason** to **Going Live**. It might take a few minutes for the process to complete, at which time the **Status Reason** will change to **Live**.

1. Go to **Marketing &gt; Lead Management &gt; Leads** to open a list of available leads. Then choose **+ NEW** from the command bar to create a new lead.  
    ![Create a test lead to see its score](media/scoring-lead-example.png "Create a test lead to see its score")

    Do the following:
    - In the **Contact** section, fill out the **Topic**, **First Name**, and **Last Name** fields. The values aren’t important for this exercise.
    - In the **Company** section, set the **City** to “London” and the **Country/Region** to “England”.
    - Choose **Save** from the command bar.

    On save, the page refreshes and adds a business process flow (BPF) at the top and several new sections to the body of the page.

1. Look for the **Lead Scores** section near the bottom-right of the page (you may need to scroll). Each lead scoring model is listed here, including your new one. It might take a few minutes for the score to be calculated, but once it is, you should see that it shows a score of 110 points.

    > [!TIP] Segments in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can only include contacts, not leads, which means that you can only address marketing emails to contacts. Therefore, most of your leads should be associated with a contact to enable scoring on events such as email opens, event registrations, and other interactions with your marketing initiatives (though this is not especially important for this exercise).
    > 
    > Your landing pages will typically either create a lead/contact pair when creating a new contact, or associate new leads with existing contacts when available. When you create a lead manually, as you did here, you can associate with a contact using the **Existing Contact** field in **Qualify** menu of the business process for the lead. The associated contact is also listed in the **Stakeholders** section for the lead.
    > 
    >![Link a lead to an existing contact](media/scoring-lead-contact-example.png "Link a lead to an existing contact")
