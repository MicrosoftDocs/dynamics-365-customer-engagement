---
title: "Macros in the Omnichannel Administration app | MicrosoftDocs"
description: "Learn about macros and how to configure in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
---

# Preview: Automate tasks with macros 

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview of macros

In the customer service industry, agents do too many clicks to perform actions (open a form, fill the form, save the form, and so on), lot of repetitive and monotonous actions (Greet a customer, Verify a customer, Send acknowledgment mail, Take notes, and so on). These clicks and repetitive tasks could lead to human errors while agents copy and paste the data across different operations.

Macros helps address these challenges aiding users to perform day-to-day operations in a faster, efficient, and process compliant manner.

Macros are a set of sequential actions that are executed by a user. You can use the macros to automate repetitive and monotonous actions that in turn reduces the human errors (copy and paste of data) and improve the agent productivity. Ultimately, an improved agent productivity leads to lower average handling time and hence improved customer satisfaction.

The macros are like reusable component where you can use the same macro with different sessions based on your organizational requirements. These session are executed based on the context parameters that are specific to a session.



## Value propositions

- Automate repetitive and monotonous tasks with a single click

- Minimization of human errors

- Adherence to business processes

- Lower Average Handling Time

- Improved customer satisfaction

- Contextual and reusable macro

## Prerequisites

- Install Dynamics 365 Productivity Tools solution

## Built-in actions

As an administrator, you can use the built-in actions any number of times across differnt macros to automate and perform operations.

The following are the built-in actions.

   > [!div class=mx-imgBorder] 
   > ![Macro actions](../media/macro-actions.png "Macro actions")    

### Open a new form to create a record

This action is used to open a new form to create a record. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to open.<br> This is a mandatory field. | incident |
   | Entity Form Id | Specify the form Id.<br> This is an optional field. |
   | Attribute Name | Specify the attribute logical name. You need to provide the attribute name in order to pre-populate the field with a value.| |
   | Attribute Value | Specify the attribute value. You need to provide the attribute value to pre-populate for the attribute field. | |
   

### Open an existing form

This action is used to open an existing record form. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to open. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record id. <br>This is a mandatory field.| |
   | Entity Form Id | Specify the form Id. <br>This is an optional field. | |

### Open a record grid

This action is used to open an record grid. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity for which you want to open the grid. <br> This is a mandatory field. | incident |
   | View Id| Specify the view Id that you want to open.<br> This is a mandatory field. | |
   | View Type | Specify the view type. <br>This is a mandatory field. | |

### Search knowledge base for the populated phrase

This action is used for searching knowledge articles based on the populated phrase. This action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to search for knowledge articles. You can provide the context data. For example, the context data parameter can be case title. |  |

### Search for a phrase

This action is used for searching knowledge articles based on the populated phrase. This action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to do a relevance search. You can provide the context data. For example, the context data parameter can be case title. <br> This is a mandatory field.  |  |

### Update an existing record

This action is used to update an existing record. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record id. <br>This is a mandatory field.| |
   | Attribute Name | Specify the attribute logical name for which you want to update.| |
   | Attribute Value | Specify the attribute value that will be updated for above mentioned attribute. | |

### Open an email form with predefined template

This action is used to open an email with a predefined template. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record id. <br>This is a mandatory field.| |
   | Email Recipients | Specify the recipients detail to whom you want the mail to be sent. <br> This is a mandatory field. | |
   | Template Id | Specify the id of the template that must displayed in the email. <br> This is a mandatory field. | |

### Resolve a case

This action is used to open an email with a predefined template. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Billable Time |  Specify the time that is billable. <br> This is a mandatory field. | incident |
   | Incidentid| Specify the case id that you want to close. <br>This is a mandatory field.| |
   | Resolution | Specify the reason to resolve the case. <br> This is a mandatory field. | |

## Use automation dictionary to pass macro context data parameters

Macros are a set of configured actions that are executed on-demand by users. As an administrator, you need to configure the actions that a macro must perform. To configure the actions, you need to provide certain data parameters keys. When the agent runs the macro, these data parameters keys are replaced by the contextual values.

To learn more, see [Use automation dictionary to pass data parameter keys](automation-dictionary-keys.md#pass-data-parameter-in-macros).

## Create macro

1. Sign in to the Omnichannel Administration app.

2. Select **Macros** under **Agent Experience**.

3. Select **+ New**.

4. Specify the following in the **Create macros** page.

    | Field | Description | Example value |
    |-------------|-----------------------------------|------------------------------------|
    | Name | Provide a name to the macro. The name is displayed to the agent at the run time. | Create case |
    | Description | Describe the purpose of the macro. The description is displayed to the agent at the run time. | This macro action is used to create a case. |

5. Select **Start macro execution**, and then select **+ New step**.

   > [!div class=mx-imgBorder] 
   > ![Create macro](../media/create-macro1.png "Create macro")

6. Select an action from a list of built in actions. You can add as many as actions as per your business requirements.

    | Purpose | Action name |
    |-----------------------------|---------------------------------------------|
    | Open a new form to create a record | Create new |
    | Open an existing form | Open form |
    | Open a record grid | Open grid |
    | Search the knowledge base for the populated phrase | Search knowledge articles |
    | Do a relevance search based on the phrase | Search |
    | Update an existing record | Update record |
    | Open an email form with predefined template | Open email |
    | Resolve a case | Resolve case |

    For example, select **Open a new form to create a record**, and the step appears.

7. Specify the values in the fields.

8. Select **Show advanced options** to add required attributes and values. If required, you can select **+ Add new item** to add more attributes.

   > [!div class=mx-imgBorder] 
   > ![Macro actions](../media/macro-fields.png "Macro actions") 

9. Select **Save and close** to save and close the macro changes.

Now, when the agent executes the macro, the actions will be executed by fetching the data parameter keys according the context available from the sources.

## See also

[Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md)

[Agent scripts](agent-scripts.md)

[Smart Assist](smart-assist.md) 
