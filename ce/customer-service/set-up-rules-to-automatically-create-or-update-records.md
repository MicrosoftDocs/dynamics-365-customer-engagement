---
title: Set up rules to automatically create or update records (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to set up rules to automatically create or update records in Dynamics 365 for Customer Service
keywords: Set up rules automatically; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 09/15/2017
ms.topic: article
ms.service: crm-online
ms.assetid: 1cbbf33b-e194-4ff3-b840-64e60b094dc9
---

# Set up rules to automatically create or update records (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 
Every organization has multiple applications to capture customer interactions. The ability to channel external data into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] records can significantly improve the efficiency of your sales, marketing, and service teams, and increase the quality of your data. You can now direct this data from various applications and external sources into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] with the help of *record creation and update rules*.  
  
By using record creation and update rules in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can automatically create or update system or custom records from incoming [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] activities, such as emails, social activities, or custom activities, without writing any code. Not just that, you can set up the rule to convert the incoming activity into multiple [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records. For example, you can create a case and a lead from a single social activity.  
  
 A record creation and update rule consists of rule items that define the conditions for creating or updating records, and also defines what actions or steps to take on the newly-created records. The rule also contains channel properties that are used to define conditions for rules, and also for setting properties of the record you’re creating or updating.  
  
 To enable the rule to update records, you must add an **Update** step to the rule. Only the entity that you select in the **Update** step is updated based on the properties you set.   
  
<a name="bkmk_SupportedActivities"></a>   
## Activities and entities supported by record creation and update rules  
 By default, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] supports creating records from the following activities, also called source types in the context of record creation and update rules:  
  
-   Email  
-   Social activity  
-   Task  
-   Phone call  
-   Appointment  
-   Service activity  
-   Custom activity  
  
These activities can be converted to any default (system) entity records or custom entity records. For example, you could create a lead, opportunity (system record), or incident (custom record) from an incoming email.  
  
<a name="bkmk_ExternalSources"></a>   
## Capture data from external sources  
 You can also capture additional valuable customer information provided by an external application in the form of JSON (a collection of name-value pairs), and use it to enhance the quality of the target records and set various conditions in the record creation and update rules.  
  
 Every default (out-of-the-box) activity or custom activity has an Additional Parameters attribute. This attribute stores the JSON payload received from an external application.  
  
 To capture this information in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], you can define channel properties and associate them with a particular rule or share them across multiple rules of the same source type. For example, along with a social post, you can capture important information about the post, such as sentiment value. Sentiment value is the property of social activity, so you can use this property in any other record creation and update rule of type Social Activity.  
  
 Here’s the correct format in which [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] should receive the JSON payload (data received as a name-value pair in JSON format) from the external application:  
  
{“PropertyName1”:”Propertyvalue1”; “PropertyName2”:”Propertyvalue2”}  
  
> [!NOTE]
>  Any configuration done in the channel properties is only valid if those name-value pairs exist in the JSON payload. Also, you must only use parameters received from the external application in the rule item conditions and as record properties.

  
<a name="bkmk_ActivateDeactivate"></a>   
## Activate or deactivate a rule  
 For any record creation and update rule to apply to a matching incoming activity, after you add the rule items, you must activate the rule.  
  
 When a record creation and update rule is activated, a corresponding workflow is created automatically. You can use channel properties to define a workflow’s conditions and operators in mapping the target entity attribute values. For complex scenarios, you may configure child workflows.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure workflow steps](../customize/configure-workflow-steps.md)  
  
<a name="bkmk_RuleAndQueues"></a>   
## How do record creation and update rules work with queues?  
 In a record creation and update rule, when you specify a queue for a source type, any incoming activity from that source is added as a queue item for that specified queue. That is, if a rule for a particular source activity and queue combination is active, the rule processes the incoming activity on that queue to create or update records.  
  
 For an email source type, specifying a queue is mandatory. For all other source types including custom activities, it is optional.  
  
<a name="bkmk_RulesInSolutions"></a>   
## Rules in solutions  
 The record creation and update rules can be packaged as a part of a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] solution. Customizers and developers distribute solutions so organizations can use [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to install and uninstall the business functionality defined by the solution.  
  
 Keep the following things in mind about using rules in solutions:  
  
-   Any rule that you created in [!INCLUDE[pn_crm_online_2015_update_1](../includes/pn-crm-online-2015-update-1.md)] or later can’t be exported to an earlier release.  
  
-   Any rules upgraded to and edited in [!INCLUDE[pn_crm_online_2015_update_1](../includes/pn-crm-online-2015-update-1.md)] or later can’t be exported back to an earlier release.  
  
<a name="bkmk_Prereqs"></a>   
## Prerequisites 
  
Before you can use automatic record creation rules, be sure your external application/social engagement system is already integrated with your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance.  
  
If your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance meets the prerequisites, all you need to do is set up rules in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] that will automatically create or update a support case, lead, opportunity, appointment, task, and more from incoming activities.  
  
<a name="bkmk_SetUpRules"></a>   
## Set up a rule to create and update records automatically  
  
1.  Make sure that you have the customer service, sales manager, or marketing manager role or equivalent permissions.  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2.  Go to **Settings** > **Service Management**. 
  
3.  Click **Automatic Record Creation and Update Rules**.  
  
4.  To create a record creation and update rule, click **New**.  
  
     -OR-  
  
     To edit an existing rule, in the list of rules, open the rule you want to edit.  
  
5.  Type or modify information in the fields.  
  
     Hover over the field labels to see what to enter:  
  
    - **Name**. Type the name of the rule.  
  
    - **Source Type**. From the drop-down list, select the activity that’s the source of the record.  
  
    - **Queue**. Select the queue the rule applies to. Incoming activity arrives in the queue, and then the valid rule and rule item applies for creation or update of records.  
  
         Here are a few things to consider:  
  
        -   For all activities and custom activities, except email, specifying a queue is optional. For all such activities you can have only one rule with an associated queue and one rule without an associated queue active at any given time. For example, for a Social Activity source type, you can have two active rules, one with a queue specified, and one without a queue.  
  
        -   If you selected Email as the source type for this rule, you can’t activate the rule unless you select a queue.  
  
        > [!NOTE]
        >  You can associate only one rule per source type to a specific queue. If you’re creating a rule to convert an email to a case, make sure you specify an email address for this queue. Otherwise, automatic record creation for email won’t work. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a queue](../customer-service/create-edit-queue.md)  
  
6.  Click **Save**.  

## Set Channel Properties
  
1.  Under **Channel Properties**, in the **Additional Properties** box, click a channel property group.  

    > [!NOTE]
    >  When you select a property group for a record creation and update rule, you can use the channel property group’s property items in the rule item conditions or while setting properties for the target record. After you activate a rule, you can’t remove or change the selected property group. You can select another property group only after you remove the referenced property items of the previous property group from the rule items. When you try to select a new property group without removing the property references of the previous property group, you’ll see an error.  
    
To learn more about creating channel property groups and adding properties to them, see [Set up channel properties](../customer-service/set-up-rules-to-automatically-create-or-update-records.md#bkmk_SetUpChannelProperties) later in this topic.  

## Set Email conditions
If the source type for the rule is set to **Email**, specify the conditions for converting the email to the target record.  

1. **Create records for email from unknown senders**. If you select this check box, all email messages from unknown senders (a sender whose email address isn’t present in any [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records) are converted to new records (based on the conditions you define). A contact record is also created for this unknown sender.  

    > [!NOTE]
    > [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] determines what record to create based on the entity you select in the **Create Record** step under **Actions**.  

    If you don’t select this check box, records are created only for email messages that have a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] contact or account as the senders.  

    This option, in conjunction with the **Automatically create records in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]** option in the rule owner's Personal Options, determines whether a case and contact record is created (see [Set personal options](../basics/set-personal-options.md)).  

2. **Create case if a valid entitlement exists for the customer**. If you select this check box, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] creates a case only if an active entitlement exists for the customer.  

    If the sender of the email is a contact with a parent account, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] creates a record if the contact’s parent account has a valid entitlement, and the contact is listed in the **Contacts** section of the entitlement or if the **Contacts** section is empty (which means the entitlement is applicable to all contacts for the customer).  

3. **Create cases for activities associated with a resolved case**. If you select this check box, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] creates a case if the email is related to a resolved case. If the email is related to an active case, a new case won’t be created.  

4. **Create case when the case associated with the activity is resolved since**. If you select the **Create cases for activities associated with a resolved case** check box, select the duration here. [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] creates a case only if the case is resolved earlier than the duration you specify. If the incoming email is related to a case resolved later than the specified duration, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] only associates the incoming email with the existing resolved case; a new case won’t be created.  

5. **Send automatic email response to customer on record creation**. Select this check box if you want to automatically send email responses to the sender of the email after a target record for the email is created.  

6. **Select email template to respond to customer.**  If you select the **Send automatic email response to customer on record creation** check box, select an email template (global email template or email template of any entity type). If you don’t select a template, an automatic response won’t be sent.  

## Set Social Activity conditions
If the source type for the rule is set to Social Activity, specify the conditions for converting the social activity to the target record.  

1. **Create records for blocked social profile**. If you select this check box, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] creates or updates a target record for the social posts (social activities) from social profiles that are blocked by you.  

    > [!NOTE]
    >  Social posts appear in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] as social activities.  

2. **Create records for direct messages only**. If you select this check box, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] creates the target record only when the social posts are sent as direct or private messages. If you clear the check box, records are created for all social posts including public messages (timeline).  

    > [!NOTE]
    > [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] determines what record to create based on the entity you select in the **Create Record** step under **Actions**.  

## Set record creation details
In the **Specify Record Creation and Update Details** section, click ![Add a record button](../customer-service/media/crm-ua-add-record.gif "Add a record button") to define the conditions for creating or updating a record and specify the properties of the record.  

1.  In the **Name** box, enter a meaningful name for the rule item.  

2.  In the **Conditions** section, select the record, channel properties, fields, and relational query operators to specify when a target record should be created or updated.  

    For example, to create a record from a social post (social activity) with a sentiment value of less than 3, an influence score greater than 60, and hashtags containing SilverCreditCard, you can add the following conditions:  

    ![Add conditions for record creation or update rule](../customer-service/media/crm-ua-record-creation-rule-item-conditions.png "Add conditions for record creation or update rule")  

    > [!NOTE]
    > You can also use channel properties in your conditions.  

    ![Use channel properties in record creation rules](../customer-service/media/crm-ua-record-creation-rule-item-conditions-channel-properties.png "Use channel properties in record creation rules")  

    Here’s the rule item after you add all the conditions:  

    ![Rule item with conditions specified](../customer-service/media/crm-ua-record-creation-rule-item-with-all-conditions.png "Rule item with conditions specified")  

3.  Add steps to create or update records for the incoming activity that matches the conditions you defined earlier.  

    a.  Under **Actions**, click **Add Step** > **Create record**.  

    b.  In the **Create** box, select the record type for the record you want to create from the incoming activity. For example, if you want to create a case from the social activity, select **Case**.  

      > [!NOTE]
      >  If the incoming activity has a regarding object set, and if the regarding object entity and the entity selected in the **Create Record** step aren’t the same, no workflow is applied and the actions defined in the rule are not executed.  

    c.  Click **Set Properties**.  

       The entity form is displayed. You can map the target entity fields to the social activity record data, including channel properties. Some of the mappings are available out of the box: Case title, Customer, and Origin (highlighted in yellow). The out-of-the-box mappings can be changed and new mappings can be added using the **Form Assistant** control.  

       ![Set properties of a record in case creation rule](../customer-service/media/crm-ua-set-properties-case.png "Set properties of a record in case creation rule")  

       The new record that is created will be automatically set as the regarding record of the incoming activity record. There is only one regarding object to the social activity, so, only one **Create** record action is possible in the **Actions** section.  

    d.  To add more actions, under **Specify Other Actions**, click **Add Step** > \<Action>. The available actions are: Create Record, Update Record, Send Email, or Start Child Workflow.  

       Learn more about each of these actions in [Configure workflow steps](../customize/configure-workflow-steps.md).  

4.  Click **Save and Close**.  

    > [!NOTE]
    > - Data types "Option Set" and "Two Option" are not supported in string type conditions.  
    > - The property items for each of the supported data types need to have a default value. This requirement is important in scenarios where the configured property line items have a blank incoming web request. In such cases, the property line item will take the default value when referred to in a workflow.  
  
## Turn on the rule
Turn on the rule so that [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] can start creating or updating records for incoming activities based on the defined conditions. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Activate a record creation and update rule](../customer-service/set-up-rules-to-automatically-create-or-update-records.md#bkmk_ActivateRule).  

> [!TIP]
>  Developers can also apply rules retroactively to the incoming [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records that might have been skipped while a rule was edited. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [ApplyRecordCreationAndUpdateRuleRequest Class](../developer/webapireference/actions/applyrecordcreationandupdaterule.md)  -->

<a name="bkmk_SetUpChannelProperties"></a>   
## Set up channel properties  
 Every default or custom activity has an **Additional Parameters** attribute. This attribute stores the JSON payload received from an external application.  
  
 You can find these parameters in the **Additional Parameters** field of any incoming activity.  
  
 To capture this information in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and associate it with the record creation or update rule, you can define channel properties in a channel property group and associate them with a rule or share them across multiple rules. For example, along with a social post, you can capture important information about the post, such as rating or influencer score. Rating and influencer score are the properties of social channel.  
  
### Create channel property groups and add channel properties  
  
1.  After you save the record creation and update rule form, under **Channel Properties** section, in the **Additional Properties** box, click the lookup button, and then click **New**.  
  
 ![Add channel properties for record creation rule](../customer-service/media/crm-ua-record-creation-rule-additional-properties.png "Add channel properties for record creation rule")  
  
 A channel property group form opens.  

 > [!IMPORTANT]
    >  A property group record contains multiple property items.  
    >   
    >  To fix this issue, first delete the properties from the conditions and steps that use the record, and then save or activate the rule.  
  
2.  Enter a meaningful name for the property group, so you can easily identify it while adding it to any record creation or update rule.  
  
3.  The **Source Type** field will be automatically set to the source type of the record creation and update rule.  
  
4.  Click **Save**.  
  
5.  In the **Channel Properties** section, click **+** to add in the group-specific channel properties.  
  
6.  In the **Channel Property** form, enter the following:  
  
    a. **Name**. Type the property name as it appears in the activity’s payload.  
  
      > [!NOTE]
        >  The name can contain only alphanumeric and underscore characters and shouldn’t be longer than 300 characters.  
  
       To see properties received for an activity, go to **Sales** or **Service** or **Marketing** > **Activities**, and open the activity, and see the **Additional Parameters** field.  
  
      > [!NOTE]
        >  This field isn’t available on the activity form by default. A system customizer can add the field to the activity forms. The field will have the JSON payload only when the external application sends it for the activity.  
  
       ![Tweet payload in the social activity record](../customer-service/media/crm-ua-tweet-payload-json.png "Tweet payload in the social activity record")  
  
       > [!IMPORTANT]
        > - Create a channel property for each name from the name-value pair that you want to use in your record creation and update rule. For example, you could use `influenceScore` as a property name.  
        > - The information in the JSON payload isn’t very easy to read. To make it more readable, you can use [online JSON parser](http://json.parser.online.fr/) that will provide a better output.  
        > - The property group doesn’t support adding nested values in a JSON payload as channel properties. The following sample shows the "FollowersCount" under the user node as a nested JSON key-value pair.  
        >   
        > ![Nested value in JSON payload](../customer-service/media/crm-ua-json-payload-nested-values.png "Nested value in JSON payload")  
  
    b. **Data Type**. Select a data type for the channel property. For example, if the property is influence score, use the data type as Whole Number because its value can’t be in decimals.  
  
       The selected data type will determine the relational query operators when you use the property to define conditions in the record creation and update rule items. [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] supports creating properties only of the following data types: Floating Point Number, Single Line of Text, and Whole Number.  
  
      > [!NOTE]
      > - Option Set and Two option data types are supported in conditions of type string. You’ll have to type out the option set value in the conditions.  
      > - [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] sets a default value for property items for each of the supported data types. This is for scenarios when a channel property is used in a workflow but the incoming payload has no value provided from the external channel; the workflow conditions in which the property is referred use a least the following default value: String: “”, Whole Number: -2,147,483,648, Float: -1e+011.  
  
    c. **Application Source**. Type the name of the application that this property is related to, for example, [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)].  
  
    d. **Description**. Type details to further explain what the property is for.  
  
7.  When you’re done, click **Save & Close**.  
  
     You can see all the properties in the channel property group form.  
  
 ![Add channel properties to channel property group](../customer-service/media/crm-ua-channel-property-group.png "Add channel properties to channel property group")  
  
<a name="bkmk_ActivateRule"></a>   
## Activate a record creation and update rule  
 For any record creation and update rule to apply to a matching incoming activity, after you add the rule items, you must activate the rule.  
  
### To activate a record creation and update rule  
  
1.  Go to **Settings** > **Service Management**. 
  
2.  Click **Automatic Record Creation and Update Rules**.  
  
3.  Open the rule you want to activate, and on the command bar, click **Activate**.  
  
    > [!NOTE]
    >  You can have two record creation and update rules active at a time for any source type, except email—one with queue and one without a queue. You can have only one record creation and update rule active for the source type Email, and this rule should have a queue specified.  
  
     After the rule is active, the only way to change the rule is to first deactivate it. Open the rule, and on the command bar, click **Deactivate**.  
  
<a name="bkmk_RecordCreationFromQueue"></a>   
## Manage automatic record creation and update from a queue form  
 You can create or manage an automatic record creation and update rule from a queue form, too. To do this, open the queue record, and on the command bar, click **Email Activity Conversion Settings** or **Social Activity Conversion Settings**.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a queue](../customer-service/create-edit-queue.md)  
  
<a name="bkmk_Upgrade"></a>   
## Upgrade considerations  
 Here are a few things you should know if you’re upgrading to [!INCLUDE[pn_crm_online_2015_update_1](../includes/pn-crm-online-2015-update-1.md)] or later from an earlier release, and have existing case creation rules for email and social activity.  
  
|Existing rules prior to upgrade|What happens to the rules after upgrade?|  
|-------------------------------------|----------------------------------------------|  
|A rule that has rule items with conditions and properties defined|-   The rule and rule items are upgraded and the properties and conditions in the existing rule items are preserved.<br />-   A new rule item is created with blank conditions. A new Create Record step (with Case selected) is added with out-of-the-box property mapping. The rule items are applied in an order and the newly-created rule item is considered last in the order.|  
|A rule that has a rule items with conditions , but no properties defined|-   The rule and rule items are upgraded and the conditions in rule items are preserved.<br />-   A new rule item is created with blank conditions. A new Create Record step (with Case selected) is added with out-of-the-box property mapping. The rule items are applied in an order and the newly-created rule item is considered last in the order.|  
|A rule that has a rule items with no conditions or properties defined|-   The rule and rule items are upgraded.<br />-   A new rule item is created with blank conditions. A new Create Record step (with Case selected) is added with out-of-the-box property mapping. The rule items are applied in an order and the newly-created rule item is considered last in the order.|  
|A rule that has a rule items with properties, but no conditions defined|-   The rule and rule items are upgraded and the properties in the rule items are preserved.<br />-   A new rule item is created with blank conditions. A new Create Record step (with Case selected) is added with out-of-the-box property mapping. The rule items are applied in an order and the newly-created rule item is considered last in the order.|  
|A rule with no rule items|-   The rule is upgraded.<br />-   A new rule item is created with blank conditions. A new Create Record step (with Case selected) is added with out-of-the-box property mapping. The rule items are applied in an order and the newly-created rule item is considered last in the order.|  
|An active case creation rule for social or email source types, with a queue specified|All such rules will be upgraded in an active state.|  
|An active case creation rule for social or email source types, without a queue specified|All such rules will be upgraded and deactivated. This is because even in [!INCLUDE[pn_v6_online_ur1](../includes/pn-v6-online-ur1.md)], a case creation rule without a queue did not apply and create any record.|  
  
### See also  
 [Create rules to automatically route cases](../customer-service/create-rules-automatically-route-cases.md)   
 [Create or change a queue](../customer-service/create-edit-queue.md)
