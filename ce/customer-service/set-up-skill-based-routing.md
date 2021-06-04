---
title: "Set up skill-based routing | MicrosoftDocs"
description: "Use the information to set up skill-based routing for unified routing in Customer Service."
ms.date: 06/02/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Set up skill-based routing for unified routing

The steps to configure skill-based routing are as follows:

1. [Create a rating model](setup-skills-assign-agents.md#create-a-rating-model).
2. [Create skill types and skills](setup-skills-assign-agents.md#create-skill-types).
3. [Assign agents to skills](setup-skills-assign-agents.md#assign-agents-to-skill).
4. [Set exact or closest match as the default skill matching algorithm for a workstream](create-workstreams.md#configure-work-distribution).
5. Choose one of the following skill-classification methods:
   - [Author manual classification rules to attach skills for a workstream](configure-work-classification.md#create-manual-skill-classification-rulesets).
   - [Setup intelligent skill finder model](#set-up-intelligent-skill-finder-model) and [Author machine learning-based classification rules to attach skills](configure-work-classification.md#create-machine-learning-based-skill-classification-rulesets).
6. [Choose out of box assignment method or author a custom assignment method for a queue](assignment-methods.md).
7. [Enable skill control for the agent](add-skill-control.md).


## How skills are matched

For a workstream, how **Default skill matching algorithm** works when you set the value as exact match or closest match is explained in this section. When the work classification skill rules attach skills and proficiency level, the assignment method matches the required skill with the skills of the agent. The system assigns the conversation to an agent based on the skill criteria chosen.

You can achieve the skill matching based on the business requirements:

- Exact skill matching
- Closest or nearest skill matching

### Exact match

In exact skill matching, the assignment logic searches for an agent with the required skills and proficiency.

Exact match filters all matched agents whose rating value is greater than or equal to the required value, and then orders them based on the higher available capacity, capacity profile, or round robin as per the chosen assignment method.

If an agent isn't available with all the required skills and corresponding proficiency, then the conversation remains unassigned in the queue.

You can configure exact skill match in one of the following ways:

- In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Exact Match**. In the assignment method of the queue, choose one of the out-of-the-box assignment methods (highest capacity or round robin). The exact match algorithm does not apply to work items if custom assignment method is applied to a queue.
- Create a custom assignment method and create rules on attribute user skills:

  In exact skill match, as part of custom assignment method, you can write rule conditions to enable assignment logic to search for agents who match all the required skills or match all skills within a skill type. The matched agents can be ordered using the following order by options:
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficient
  - Most proficient within skill type
  - Skill count
  - Skill count within skill type
  - Round robin
  - Capacity

  For example, order by nearest proficiency or most proficiency will have the agent with skill proficiency nearest to required proficiency or highest proficiency at the top accordingly. It can be configured within a skill type as well.

  The following table lists a few examples of how the skills are matched and results are ordered when the default skill-matching algorithm is "exact match".

  |Skills required|Agent characteristics|Scenario description|Rule condition|Order by/Result   |
  |----|----|---|----|----|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Name: Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Name: Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>| Exact match all skills | Agent.User skills.Exact match.All skills AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity| Choose from one of the Order by options: <ul><li> **Available capacity**: Eric</li><li> **Nearest Proficient**: Carlos</li><li> **Most Proficient**: Eric </li><ul>|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Name: Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Name: Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>|Exact match language skill only | Agent.User skills.Exact match.Skill type: Language AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options: <ul><li> **Available capacity**: Eric</li><li> **Nearest Proficient**: Carlos</li><li> **Most Proficient**: Eric </li><ul>|
  ||||||

### Closest Match

For business scenarios where finding agent at the earliest is more important than waiting for agent with exact required skills, unified routing provides with an option to order agents using proficiency or skill count and thereby achieving closest skill match.

Closest match orders all agents based on their closeness to the required skill and proficiency. For example, if the required skills are four, then agents with four skills will be put on top (exact qualified), then agent with five skills (overqualified), followed by agent with three skills (under qualified).

If no agent is available with any of the required skills, then the conversation might be assigned to an agent without any required skills.

You can achieve closest skill match in one of the following ways:

- In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Closest Match**. In the assignment method of the queue, choose one of the out-of-the-box assignment methods (highest capacity or round robin).

  In this scenario where closest match is chosen as the skill matching algorithm at workstream level, and one of the out-of-the-box assignment method is chosen (round robin or highest capacity); if more than one agent with same skill score is there; system won't order them by round robin or highest capacity. System will keep assigning all the incoming work items to the same agent till other constraints like capacity and presence are being satisifed.

- Create a custom assignment method and create order by using proficiency or skill count to achieve closest match.
  
  You need to select order by > Proficiency > All skills or skill type > Nearest Proficient.

  In closest skill matching as part of custom assignment method, you can choose from the following order by options:
  
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficiency
  - Most proficiency within skill type
  - Skill count
  - Skill count within skill type
  
   The following table lists a few examples of how the skills are matched and results are ordered when the default skill-matching algorithm is "closest match".

  |Skills required|Agent characteristics|Scenario description|Rule condition|Order by/Result|
  |----|----|---|----|----|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required :2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li> <li>Spanish (Type: Language); Proficiency required: 3</li></ul> | <ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Name: Jamie; Cafe A-100 (1); Coffee machine (2); Spanish (1)</li> |Closest match all skills|Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul> |
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Name: Jamie; Cafe A-100 (1); Coffee machine (2); Spanish (1)</li>|Closest match product skill only |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul>|
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4)</li><li>Name: Jamie; Cafe A-100 (1)</li>|Closest match with all skills using skill count |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Order by option: <br>Skill count: Carlos > Eric > Jamie|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li><li>Spanish (Type: Language); Proficiency required: 3</li></ul> |<ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4);</li><li>Name: Jamie; Cafe A-100 (1);</li></ul> |Closest match product skill only using skill count |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Order by:<br> Skill count: System will randomly pick from Carlos or Eric|
  |||||

> [!NOTE]
> We recommend that you use the same rating model across skills. However, if skills that belong to different rating models are there, then the system will normalize and calculate the skill scores.

## Set up intelligent skill finder model

To configure ML-based skill classification rulesets, you can configure intelligent skill finder models that will be used for predicting skills.

You can create and train machine-learning models that use AI to determine the necessary skills for new work items. You can create and train the model by using the data in Microsoft Dataverse. However, if you're trying to set up the model in a new organization or if skill-based routing wasn't in use, you might not have the needed skill data. In such conditions, you can use data from another application by using the **Import from Excel** option in the skill finder model.

Intelligent skill finder depends upon the custom AI Builder category classification model. Therefore, AI Builder should be available in the geographical region where you want to use intelligent skill finder. More information: [Availability of AI Builder](/ai-builder/availability-region).

### Create skill finder models

Perform the steps in this section to set up the intelligent skill finder model. You can create as many models as your business requires.

1. In Omnichannel admin center, select **User attributes** in the site map, and then select **Manage** beside **Intelligent skill finder**.
2. Select **New**, and on the **Configuration** tab of **New skill finder model** page, enter a name.
3. In **Data criteria**, enter the following to form the dataset records:
    - **Attributes (Required)**: Select attributes in the Attributes and related list to form the training dataset. The corresponding attribute values will be merged in the sequence they are added and will be used to form the input string for the model training data.
    - **Filters**: Optionally, apply filters to conditionally select the relevant records.
    - **Date range**: Select a value to set the time period for which the records need to be loaded.
    
    ![Configure skill finder model](media/ur-skill-model.png "Configure skill finder model")

4. Select **Save**, and then select **Load training data**. The **Training data** tab appears and displays the data load status.
5. After the load is complete, review the load, and edit the records if you want to modify the tags.
6. In the **Training data** section, select the checkbox beside **Input data** to select all the records, and select **Approve**. You must approve a minimum of 50 records for the model to be trained.
7. Select **Train model**, and select **Train model** on the confirmation dialog box.
8. After the status changes to training completed, select the rows that you want to publish, and select **Publish model**. The skills model is ready for use.

You should retrain your model iteratively to improve the model with new data in Microsoft Dataverse. For example, New data would be created when agents update the skills for records or conversations.

### Use training data imported from Excel file

If you don't have data to train your model, you can populate skills and attributes data in Excel files and upload them to the application by using the import feature of Microsoft Dataverse.

To use the data from the Excel files, you must make sure of the following:

- The model name in the application should match the name in the Training record column of the Excel file.

- Name the files as msdyn_ocsitrainingdata.csv and msdyn_ocsitdskill.csv.
  
A sample of each file is as follows.

**msdyn_ocsitrainingdata.csv**

|Skill finder model|Training record name|Input data|
|------------------|--------------------|----------|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10001|Hi, I work at Trey Research. One of the automatic espresso machines is becoming overheated and starts giving a burning smell after 30 minutes of usage. Please help! Yes. No.|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10002|Hi, I work at Trey Research. One of the automatic espresso machines is becoming overheated and starts giving a burning smell after 30 minutes of usage. Please help! Yes. No., can you please connect me to an agent|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10003|Hi, I work at Trey Research. One of the automatic espresso machines is becoming overheated and starts giving a burning smell after 30 minutes of usage. Please help! Yes. Not really, can you pls help|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10004|Hi, I work at Trey Research. One of the automatic espresso machines is becoming overheated and starts giving a burning smell after 30 minutes of usage. Please help! Yes. Not at all, can I speak to a human|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10005|Hi, I work at Trey Research. One of the automatic espresso machines is becoming overheated and starts giving a burning smell after 30 minutes of usage. Please help! Yes. No. Need urgent attention|
||||

**msdyn_ocsitdskill.csv**

|Training record|Characteristic mapping|Characteristic|
|---------|--------|-----------|
|CCSFM01-Contoso Coffee training data A10001|Café A-100|Café A-100|
|CCSFM01-Contoso Coffee training data A10001|Heating|Heating|
|CCSFM01-Contoso Coffee training data A10001|Electrical|Electrical|
|CCSFM01-Contoso Coffee training data A10002|Café A-100|Café A-100|
|CCSFM01-Contoso Coffee training data A10002|Heating|Heating|
||||

Perform the following steps to upload the data for training your model:

1. On the **Skill finder model** page, enter a name for the model, and then save the form.
2. Select the **Training data** tab, and select **Import Excel**.
3. Select the .csv files to upload in the import tool.
   
   ![Import data file using Excel](media/skill-finder-excel.png "Import data file using Excel")

4. Review the upload settings, and select **Finish** after you go through the stages. The data upload starts. The time taken for the data upload depends on the number of records.
5. Optionally, you can select **Refresh** to see the updated status of the data upload.
6. Perform the steps 5 through 8 in [Create skill finder models](#create-skill-finder-models) to approve, train, and publish your model.

### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Overview of unified routing](overview-unified-routing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]  