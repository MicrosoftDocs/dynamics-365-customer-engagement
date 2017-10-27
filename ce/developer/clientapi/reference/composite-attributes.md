---
title: "Composite attributes in Dynamics 365 Customer Engagement in Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about the attribute addOnchange method to set a function to be called when the attribute value is changed." 
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 9f3b2fed-fde5-46e4-8c59-43aa51aa82df
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Composite attributes 

Some fields added to a form can represent multiple items of data. These *composite attributes* behave differently from other attributes when displayed in the web application and you must write scripts differently to use them properly.

The following table lists the composite attributes availavle in Customer Engagement:

<table>
    <tbody>
        <tr>
            <th scope="col">
                <p>
                    Entity
                </p>
            </th>
            <th scope="col">
                <p>
                    Display Name
                </p>
            </th>
            <th scope="col">
                <p>
                    Logical name
                </p>
            </th>
        </tr>
        <tr>
            <td rowspan="3">
                <p>
                    Contact
                </p>
            </td>
            <td>
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td>
                <p>
                    fullname
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Address 1</strong>
                </p>
            </td>
            <td>
                <p>
                    address1_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Address 2</strong>
                </p>
            </td>
            <td>
                <p>
                    address2_composite
                </p>
            </td>
        </tr>
        <tr>
            <td rowspan="3">
                <p>
                    Lead
                </p>
            </td>
            <td>
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td>
                <p>
                    fullname
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Address 1</strong>
                </p>
            </td>
            <td>
                <p>
                    address1_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Address 2</strong>
                </p>
            </td>
            <td>
                <p>
                    address2_composite
                </p>
            </td>
        </tr>
        <tr>
            <td rowspan="3">
                <p>
                    User
                </p>
            </td>
            <td>
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td>
                <p>
                    fullname
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Address</strong>
                </p>
            </td>
            <td>
                <p>
                    address1_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Other Address</strong>
                </p>
            </td>
            <td>
                <p>
                    address2_composite
                </p>
            </td>
        </tr>
        <tr>
            <td rowspan="2">
                <p>
                    Account
                </p>
            </td>
            <td>
                <p>
                    <strong>Address 1</strong>
                </p>
            </td>
            <td>
                <p>
                    address1_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Address 2</strong>
                </p>
            </td>
            <td>
                <p>
                    address2_composite
                </p>
            </td>
        </tr>
        <tr>
            <td rowspan="2">
                <p>
                    Quote
                </p>
            </td>
            <td>
                <p>
                    <strong>Bill To Address</strong>
                </p>
            </td>
            <td>
                <p>
                    billto_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Ship To Address</strong>
                </p>
            </td>
            <td>
                <p>
                    shipto_composite
                </p>
            </td>
        </tr>
        <tr>
            <td rowspan="2">
                <p>
                    Order
                </p>
            </td>
            <td>
                <p>
                    <strong>Bill To Address</strong>
                </p>
            </td>
            <td>
                <p>
                    billto_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Ship To Address</strong>
                </p>
            </td>
            <td>
                <p>
                    shipto_composite
                </p>
            </td>
        </tr>
        <tr>
            <td rowspan="2">
                <p>
                    Invoice
                </p>
            </td>
            <td>
                <p>
                    <strong>Bill To Address</strong>
                </p>
            </td>
            <td>
                <p>
                    billto_composite
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <strong>Ship To Address</strong>
                </p>
            </td>
            <td>
                <p>
                    shipto_composite
                </p>
            </td>
        </tr>
    </tbody>
</table>

## Composite attributes in the web application

When fields for composite attributes are added to a main form, the web application will show just the composite attribute. When someone edits the field, a flyout appears showing the individual attributes that comprise the composite attribute. Although not explicitly added to the form in the form editor, each of the attributes that are part of the attribute are available to the form. Although you can read the value of the composite value using [getValue](attributes/getValue.md), you can’t use [setValue](attributes/setValue.md) to change the value of the composite attribute directly; you must set one or more of the attributes referenced by the composite attribute.

You can access the individual constituent controls displayed in the flyout by name. These controls use the following naming convention: <composite control name>_compositionLinkControl_<constituent attribute name>. 

To access just the address_line1 control in the address1_composite control you would use: `formContext.getControl("address1_composite_compositionLinkControl_address1_line1")`

## Composite attributes in Dynamics 365 for tablets
Microsoft Dynamics 365 for tablets uses the same form definitions used for the entities that have composite attributes but it interprets them differently. If a composite attribute is found in the form definition, it will show all the attributes that are part of the composite attribute in that section of the form. There is no need for a flyout because all the fields are visible. You can write scripts for the form accessing each of the individual attributes just as if they had been individually added to the form.
However, the actual composite control will not be present in the Dynamics 365 for tablets page.

### Related topics
[Attributes](attributes.md)





