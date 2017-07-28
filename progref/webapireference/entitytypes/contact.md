---
title: "Microsoft Dynamics 365 Customer Engagement contact EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 27308cb4-1fb8-4f13-bfc9-d7f22ab25ae4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API contact entitytype."
---
# contact EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/contact.md](./descriptions/contact.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]contacts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Contact</td></tr>
<tr><td><b>Primary Key:</b></td><td>contactid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>fullname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|accountrolecode|Edm.Int32|**Display Name**: Role<br />**Description**: Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Decision Maker</td></tr><tr><td>2</td><td>Employee</td></tr><tr><td>3</td><td>Influencer</td></tr><tbody></table>|
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Select the primary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Bill To</td></tr><tr><td>2</td><td>Ship To</td></tr><tr><td>3</td><td>Primary</td></tr><tr><td>4</td><td>Other</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: Address 1: City<br />**Description**: Type the city for the primary address.<br />|
|address1_composite|Edm.String|**Display Name**: Address 1<br />**Description**: Shows the complete primary address.<br />Read-only<br />|
|address1_country|Edm.String|**Display Name**: Address 1: Country/Region<br />**Description**: Type the country or region for the primary address.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: Type the county for the primary address.<br />|
|address1_fax|Edm.String|**Display Name**: Address 1: Fax<br />**Description**: Type the fax number associated with the primary address.<br />|
|address1_freighttermscode|Edm.Int32|**Display Name**: Address 1: Freight Terms<br />**Description**: Select the freight terms for the primary address to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Type the latitude value for the primary address for use in mapping and other applications.<br />|
|address1_line1|Edm.String|**Display Name**: Address 1: Street 1<br />**Description**: Type the first line of the primary address.<br />|
|address1_line2|Edm.String|**Display Name**: Address 1: Street 2<br />**Description**: Type the second line of the primary address.<br />|
|address1_line3|Edm.String|**Display Name**: Address 1: Street 3<br />**Description**: Type the third line of the primary address.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Type the longitude value for the primary address for use in mapping and other applications.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Type a descriptive name for the primary address, such as Corporate Headquarters.<br />|
|address1_postalcode|Edm.String|**Display Name**: Address 1: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the primary address.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Type the post office box number of the primary address.<br />|
|address1_primarycontactname|Edm.String|**Display Name**: Address 1: Primary Contact Name<br />**Description**: Type the name of the main contact at the account's primary address.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Airborne</td></tr><tr><td>2</td><td>DHL</td></tr><tr><td>3</td><td>FedEx</td></tr><tr><td>4</td><td>UPS</td></tr><tr><td>5</td><td>Postal Mail</td></tr><tr><td>6</td><td>Full Load</td></tr><tr><td>7</td><td>Will Call</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: Address 1: State/Province<br />**Description**: Type the state or province of the primary address.<br />|
|address1_telephone1|Edm.String|**Display Name**: Address 1: Phone<br />**Description**: Type the main phone number associated with the primary address.<br />|
|address1_telephone2|Edm.String|**Display Name**: Address 1: Telephone 2<br />**Description**: Type a second phone number associated with the primary address.<br />|
|address1_telephone3|Edm.String|**Display Name**: Address 1: Telephone 3<br />**Description**: Type a third phone number associated with the primary address.<br />|
|address1_upszone|Edm.String|**Display Name**: Address 1: UPS Zone<br />**Description**: Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address1_utcoffset|Edm.Int32|**Display Name**: Address 1: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|address2_addressid|Edm.Guid|**Display Name**: Address 2: ID<br />**Description**: Unique identifier for address 2.<br />|
|address2_addresstypecode|Edm.Int32|**Display Name**: Address 2: Address Type<br />**Description**: Select the secondary address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_city|Edm.String|**Display Name**: Address 2: City<br />**Description**: Type the city for the secondary address.<br />|
|address2_composite|Edm.String|**Display Name**: Address 2<br />**Description**: Shows the complete secondary address.<br />Read-only<br />|
|address2_country|Edm.String|**Display Name**: Address 2: Country/Region<br />**Description**: Type the country or region for the secondary address.<br />|
|address2_county|Edm.String|**Display Name**: Address 2: County<br />**Description**: Type the county for the secondary address.<br />|
|address2_fax|Edm.String|**Display Name**: Address 2: Fax<br />**Description**: Type the fax number associated with the secondary address.<br />|
|address2_freighttermscode|Edm.Int32|**Display Name**: Address 2: Freight Terms<br />**Description**: Select the freight terms for the secondary address to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Type the latitude value for the secondary address for use in mapping and other applications.<br />|
|address2_line1|Edm.String|**Display Name**: Address 2: Street 1<br />**Description**: Type the first line of the secondary address.<br />|
|address2_line2|Edm.String|**Display Name**: Address 2: Street 2<br />**Description**: Type the second line of the secondary address.<br />|
|address2_line3|Edm.String|**Display Name**: Address 2: Street 3<br />**Description**: Type the third line of the secondary address.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Type the longitude value for the secondary address for use in mapping and other applications.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Type a descriptive name for the secondary address, such as Corporate Headquarters.<br />|
|address2_postalcode|Edm.String|**Display Name**: Address 2: ZIP/Postal Code<br />**Description**: Type the ZIP Code or postal code for the secondary address.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Type the post office box number of the secondary address.<br />|
|address2_primarycontactname|Edm.String|**Display Name**: Address 2: Primary Contact Name<br />**Description**: Type the name of the main contact at the account's secondary address.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Address 2: State/Province<br />**Description**: Type the state or province of the secondary address.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: Type the main phone number associated with the secondary address.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Type a second phone number associated with the secondary address.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Type a third phone number associated with the secondary address.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|address3_addressid|Edm.Guid|**Display Name**: Address 3: ID<br />**Description**: Unique identifier for address 3.<br />|
|address3_addresstypecode|Edm.Int32|**Display Name**: Address 3: Address Type<br />**Description**: Select the third address type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address3_city|Edm.String|**Display Name**: Address 3: City<br />**Description**: Type the city for the 3rd address.<br />|
|address3_composite|Edm.String|**Display Name**: Address 3<br />**Description**: Shows the complete third address.<br />Read-only<br />|
|address3_country|Edm.String|**Display Name**: Address3: Country/Region<br />**Description**: the country or region for the 3rd address.<br />|
|address3_county|Edm.String|**Display Name**: Address 3: County<br />**Description**: Type the county for the third address.<br />|
|address3_fax|Edm.String|**Display Name**: Address 3: Fax<br />**Description**: Type the fax number associated with the third address.<br />|
|address3_freighttermscode|Edm.Int32|**Display Name**: Address 3: Freight Terms<br />**Description**: Select the freight terms for the third address to make sure shipping orders are processed correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address3_latitude|Edm.Double|**Display Name**: Address 3: Latitude<br />**Description**: Type the latitude value for the third address for use in mapping and other applications.<br />|
|address3_line1|Edm.String|**Display Name**: Address3: Street 1<br />**Description**: the first line of the 3rd address.<br />|
|address3_line2|Edm.String|**Display Name**: Address3: Street 2<br />**Description**: the second line of the 3rd address.<br />|
|address3_line3|Edm.String|**Display Name**: Address3: Street 3<br />**Description**: the third line of the 3rd address.<br />|
|address3_longitude|Edm.Double|**Display Name**: Address 3: Longitude<br />**Description**: Type the longitude value for the third address for use in mapping and other applications.<br />|
|address3_name|Edm.String|**Display Name**: Address 3: Name<br />**Description**: Type a descriptive name for the third address, such as Corporate Headquarters.<br />|
|address3_postalcode|Edm.String|**Display Name**: Address3: ZIP/Postal Code<br />**Description**: the ZIP Code or postal code for the 3rd address.<br />|
|address3_postofficebox|Edm.String|**Display Name**: Address 3: Post Office Box<br />**Description**: the post office box number of the 3rd address.<br />|
|address3_primarycontactname|Edm.String|**Display Name**: Address 3: Primary Contact Name<br />**Description**: Type the name of the main contact at the account's third address.<br />|
|address3_shippingmethodcode|Edm.Int32|**Display Name**: Address 3: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address3_stateorprovince|Edm.String|**Display Name**: Address3: State/Province<br />**Description**: the state or province of the third address.<br />|
|address3_telephone1|Edm.String|**Display Name**: Address 3: Telephone1<br />**Description**: Type the main phone number associated with the third address.<br />|
|address3_telephone2|Edm.String|**Display Name**: Address 3: Telephone2<br />**Description**: Type a second phone number associated with the third address.<br />|
|address3_telephone3|Edm.String|**Display Name**: Address 3: Telephone3<br />**Description**: Type a third phone number associated with the primary address.<br />|
|address3_upszone|Edm.String|**Display Name**: Address 3: UPS Zone<br />**Description**: Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.<br />|
|address3_utcoffset|Edm.Int32|**Display Name**: Address 3: UTC Offset<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|adx_createdbyipaddress|Edm.String|**Display Name**: Created By IP Address<br />|
|adx_createdbyusername|Edm.String|**Display Name**: Created By Username<br />|
|adx_identity_accessfailedcount|Edm.Int32|**Display Name**: Access Failed Count<br />**Description**: Shows the current count of failed password attempts for the contact.<br />|
|adx_identity_emailaddress1confirmed|Edm.Boolean|**Display Name**: Email Confirmed<br />**Description**: Determines if the email is confirmed by the contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_identity_lastsuccessfullogin|Edm.DateTimeOffset|**Display Name**: Last Successful Login<br />**Description**: Indicates the last date and time the user successfully signed in to a portal.<br />|
|adx_identity_lockoutenabled|Edm.Boolean|**Display Name**: Lockout Enabled<br />**Description**: Determines if this contact will track failed access attempts and become locked after too many failed attempts. To prevent the contact from becoming locked, you can disable this setting.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_identity_lockoutenddate|Edm.DateTimeOffset|**Display Name**: Lockout End Date<br />**Description**: Shows the moment in time when the locked contact becomes unlocked again.<br />|
|adx_identity_logonenabled|Edm.Boolean|**Display Name**: Login Enabled<br />**Description**: Determines if web authentication is enabled for the contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_identity_mobilephoneconfirmed|Edm.Boolean|**Display Name**: Mobile Phone Confirmed<br />**Description**: Determines if the phone number is confirmed by the contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_identity_passwordhash|Edm.String|**Display Name**: Password Hash<br />|
|adx_identity_securitystamp|Edm.String|**Display Name**: Security Stamp<br />**Description**: A token used to manage the web authentication session.<br />|
|adx_identity_twofactorenabled|Edm.Boolean|**Display Name**: Two Factor Enabled<br />**Description**: Determines if two-factor authentication is enabled for the contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_identity_username|Edm.String|**Display Name**: User Name<br />**Description**: Shows the user identity for local web authentication.<br />|
|adx_modifiedbyipaddress|Edm.String|**Display Name**: Modified By IP Address<br />|
|adx_modifiedbyusername|Edm.String|**Display Name**: Modified By Username<br />|
|adx_organizationname|Edm.String|**Display Name**: Organization Name<br />|
|adx_profilealert|Edm.Boolean|**Display Name**: Profile Alert<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_profilealertdate|Edm.DateTimeOffset|**Display Name**: Profile Alert Date<br />|
|adx_profilealertinstructions|Edm.String|**Display Name**: Profile Alert Instructions<br />|
|adx_profileisanonymous|Edm.Boolean|**Display Name**: Profile Is Anonymous<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_profilelastactivity|Edm.DateTimeOffset|**Display Name**: Profile Last Activity<br />|
|adx_profilemodifiedon|Edm.DateTimeOffset|**Display Name**: Profile Modified On<br />|
|adx_publicprofilecopy|Edm.String|**Display Name**: Public Profile Copy<br />|
|adx_timezone|Edm.Int32|**Display Name**: Time Zone<br />|
|aging30|Edm.Decimal|**Display Name**: Aging 30<br />**Description**: For system use only.<br />Read-only<br />|
|aging30_base|Edm.Decimal|**Display Name**: Aging 30 (Base)<br />**Description**: Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />Read-only<br />|
|aging60|Edm.Decimal|**Display Name**: Aging 60<br />**Description**: For system use only.<br />Read-only<br />|
|aging60_base|Edm.Decimal|**Display Name**: Aging 60 (Base)<br />**Description**: Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />Read-only<br />|
|aging90|Edm.Decimal|**Display Name**: Aging 90<br />**Description**: For system use only.<br />Read-only<br />|
|aging90_base|Edm.Decimal|**Display Name**: Aging 90 (Base)<br />**Description**: Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />Read-only<br />|
|anniversary|Edm.Date|**Display Name**: Anniversary<br />**Description**: Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.<br />|
|annualincome|Edm.Decimal|**Display Name**: Annual Income<br />**Description**: Type the contact's annual income for use in profiling and financial analysis.<br />|
|annualincome_base|Edm.Decimal|**Display Name**: Annual Income (Base)<br />**Description**: Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.<br />Read-only<br />|
|assistantname|Edm.String|**Display Name**: Assistant<br />**Description**: Type the name of the contact's assistant.<br />|
|assistantphone|Edm.String|**Display Name**: Assistant Phone<br />**Description**: Type the phone number for the contact's assistant.<br />|
|birthdate|Edm.Date|**Display Name**: Birthday<br />**Description**: Enter the contact's birthday for use in customer gift programs or other communications.<br />|
|business2|Edm.String|**Display Name**: Business Phone 2<br />**Description**: Type a second business phone number for this contact.<br />|
|callback|Edm.String|**Display Name**: Callback Number<br />**Description**: Type a callback phone number for this contact.<br />|
|childrensnames|Edm.String|**Display Name**: Children's Names<br />**Description**: Type the names of the contact's children for reference in communications and client programs.<br />|
|company|Edm.String|**Display Name**: Company Phone<br />**Description**: Type the company phone of the contact.<br />|
|contactid|Edm.Guid|**Display Name**: Contact<br />**Description**: Unique identifier of the contact.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|creditlimit|Edm.Decimal|**Display Name**: Credit Limit<br />**Description**: Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.<br />|
|creditlimit_base|Edm.Decimal|**Display Name**: Credit Limit (Base)<br />**Description**: Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.<br />Read-only<br />|
|creditonhold|Edm.Boolean|**Display Name**: Credit Hold<br />**Description**: Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|customersizecode|Edm.Int32|**Display Name**: Customer Size<br />**Description**: Select the size of the contact's company for segmentation and reporting purposes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|customertypecode|Edm.Int32|**Display Name**: Relationship Type<br />**Description**: Select the category that best describes the relationship between the contact and your organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|department|Edm.String|**Display Name**: Department<br />**Description**: Type the department or business unit where the contact works in the parent company or business.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the contact, such as an excerpt from the company's website.<br />|
|donotbulkemail|Edm.Boolean|**Display Name**: Do not allow Bulk Emails<br />**Description**: Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotbulkpostalmail|Edm.Boolean|**Display Name**: Do not allow Bulk Mails<br />**Description**: Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|donotemail|Edm.Boolean|**Display Name**: Do not allow Emails<br />**Description**: Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotfax|Edm.Boolean|**Display Name**: Do not allow Faxes<br />**Description**: Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotphone|Edm.Boolean|**Display Name**: Do not allow Phone Calls<br />**Description**: Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotpostalmail|Edm.Boolean|**Display Name**: Do not allow Mails<br />**Description**: Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|donotsendmm|Edm.Boolean|**Display Name**: Send Marketing Materials<br />**Description**: Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do Not Send</td></tr><tr><td>0</td><td>Send</td></tr><tbody></table>|
|educationcode|Edm.Int32|**Display Name**: Education<br />**Description**: Select the contact's highest level of education for use in segmentation and analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|emailaddress1|Edm.String|**Display Name**: Email<br />**Description**: Type the primary email address for the contact.<br />|
|emailaddress2|Edm.String|**Display Name**: Email Address 2<br />**Description**: Type the secondary email address for the contact.<br />|
|emailaddress3|Edm.String|**Display Name**: Email Address 3<br />**Description**: Type an alternate email address for the contact.<br />|
|employeeid|Edm.String|**Display Name**: Employee<br />**Description**: Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|externaluseridentifier|Edm.String|**Display Name**: External User Identifier<br />**Description**: Identifier for an external user.<br />|
|familystatuscode|Edm.Int32|**Display Name**: Marital Status<br />**Description**: Select the marital status of the contact for reference in follow-up phone calls and other communications.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Single</td></tr><tr><td>2</td><td>Married</td></tr><tr><td>3</td><td>Divorced</td></tr><tr><td>4</td><td>Widowed</td></tr><tbody></table>|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Type the fax number for the contact.<br />|
|firstname|Edm.String|**Display Name**: First Name<br />**Description**: Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|followemail|Edm.Boolean|**Display Name**: Follow Email Activity<br />**Description**: Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Allow</td></tr><tr><td>0</td><td>Do Not Allow</td></tr><tbody></table>|
|ftpsiteurl|Edm.String|**Display Name**: FTP Site<br />**Description**: Type the URL for the contact's FTP site to enable users to access data and share documents.<br />|
|fullname|Edm.String|**Display Name**: Full Name<br />**Description**: Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.<br />Read-only<br />|
|gendercode|Edm.Int32|**Display Name**: Gender<br />**Description**: Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Male</td></tr><tr><td>2</td><td>Female</td></tr><tbody></table>|
|governmentid|Edm.String|**Display Name**: Government<br />**Description**: Type the passport number or other government ID for the contact for use in documents or reports.<br />|
|haschildrencode|Edm.Int32|**Display Name**: Has Children<br />**Description**: Select whether the contact has any children for reference in follow-up phone calls and other communications.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|home2|Edm.String|**Display Name**: Home Phone 2<br />**Description**: Type a second home phone number for this contact.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|isbackofficecustomer|Edm.Boolean|**Display Name**: Back Office Customer<br />**Description**: Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|jobtitle|Edm.String|**Display Name**: Job Title<br />**Description**: Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|lastname|Edm.String|**Display Name**: Last Name<br />**Description**: Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on hold time.<br />|
|lastusedincampaign|Edm.DateTimeOffset|**Display Name**: Last Date Included in Campaign<br />**Description**: Shows the date when the contact was last included in a marketing campaign or quick campaign.<br />|
|leadsourcecode|Edm.Int32|**Display Name**: Lead Source<br />**Description**: Select the primary marketing source that directed the contact to your organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|managername|Edm.String|**Display Name**: Manager<br />**Description**: Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.<br />|
|managerphone|Edm.String|**Display Name**: Manager Phone<br />**Description**: Type the phone number for the contact's manager.<br />|
|marketingonly|Edm.Boolean|**Display Name**: Marketing Only<br />**Description**: Whether is only for marketing<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|merged|Edm.Boolean|**Display Name**: Merged<br />**Description**: Shows whether the account has been merged with a master contact.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|middlename|Edm.String|**Display Name**: Middle Name<br />**Description**: Type the contact's middle name or initial to make sure the contact is addressed correctly.<br />|
|mobilephone|Edm.String|**Display Name**: Mobile Phone<br />**Description**: Type the mobile phone number for the contact.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyncrm_rememberme|Edm.Boolean|**Display Name**: Remember Me<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Allow</td></tr><tr><td>0</td><td>Do Not Allow</td></tr><tbody></table>|
|nickname|Edm.String|**Display Name**: Nickname<br />**Description**: Type the contact's nickname.<br />|
|numberofchildren|Edm.Int32|**Display Name**: No. of Children<br />**Description**: Type the number of children the contact has for reference in follow-up phone calls and other communications.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|pager|Edm.String|**Display Name**: Pager<br />**Description**: Type the pager number for the contact.<br />|
|participatesinworkflow|Edm.Boolean|**Display Name**: Participates in Workflow<br />**Description**: Shows whether the contact participates in workflow rules.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|paymenttermscode|Edm.Int32|**Display Name**: Payment Terms<br />**Description**: Select the payment terms to indicate when the customer needs to pay the total amount.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Net 30</td></tr><tr><td>2</td><td>2% 10, Net 30</td></tr><tr><td>3</td><td>Net 45</td></tr><tr><td>4</td><td>Net 60</td></tr><tbody></table>|
|preferredappointmentdaycode|Edm.Int32|**Display Name**: Preferred Day<br />**Description**: Select the preferred day of the week for service appointments.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Sunday</td></tr><tr><td>1</td><td>Monday</td></tr><tr><td>2</td><td>Tuesday</td></tr><tr><td>3</td><td>Wednesday</td></tr><tr><td>4</td><td>Thursday</td></tr><tr><td>5</td><td>Friday</td></tr><tr><td>6</td><td>Saturday</td></tr><tbody></table>|
|preferredappointmenttimecode|Edm.Int32|**Display Name**: Preferred Time<br />**Description**: Select the preferred time of day for service appointments.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Morning</td></tr><tr><td>2</td><td>Afternoon</td></tr><tr><td>3</td><td>Evening</td></tr><tbody></table>|
|preferredcontactmethodcode|Edm.Int32|**Display Name**: Preferred Method of Contact<br />**Description**: Select the preferred method of contact.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Any</td></tr><tr><td>2</td><td>Email</td></tr><tr><td>3</td><td>Phone</td></tr><tr><td>4</td><td>Fax</td></tr><tr><td>5</td><td>Mail</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Shows the ID of the process.<br />|
|salutation|Edm.String|**Display Name**: Salutation<br />**Description**: Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Select a shipping method for deliveries sent to this address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|spousesname|Edm.String|**Display Name**: Spouse/Partner Name<br />**Description**: Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Shows the ID of the stage.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the contact's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|subscriptionid|Edm.Guid|**Display Name**: Subscription<br />**Description**: For internal use only.<br />|
|suffix|Edm.String|**Display Name**: Suffix<br />**Description**: Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.<br />|
|telephone1|Edm.String|**Display Name**: Business Phone<br />**Description**: Type the main phone number for this contact.<br />|
|telephone2|Edm.String|**Display Name**: Home Phone<br />**Description**: Type a second phone number for this contact.<br />|
|telephone3|Edm.String|**Display Name**: Telephone 3<br />**Description**: Type a third phone number for this contact.<br />|
|territorycode|Edm.Int32|**Display Name**: Territory<br />**Description**: Select a region or territory for the contact for use in segmentation and analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|timespentbymeonemailandmeetings|Edm.String|**Display Name**: Time Spent by me<br />**Description**: Total time spent for emails (read and write) and meetings by me in relation to the contact record.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the contact.<br />Read-only<br />|
|websiteurl|Edm.String|**Display Name**: Website<br />**Description**: Type the contact's professional or personal website or blog URL.<br />|
|yomifirstname|Edm.String|**Display Name**: Yomi First Name<br />**Description**: Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.<br />|
|yomifullname|Edm.String|**Display Name**: Yomi Full Name<br />**Description**: Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.<br />Read-only<br />|
|yomilastname|Edm.String|**Display Name**: Yomi Last Name<br />**Description**: Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.<br />|
|yomimiddlename|Edm.String|**Display Name**: Yomi Middle Name<br />**Description**: Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the contact is associated.|
|_adx_preferredlanguageid_value|adx_preferredlanguageid<br />|User’s preferred portal language|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_defaultpricelevelid_value|defaultpricelevelid<br />|Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.|
|_masterid_value|masterid<br />|Unique identifier of the master contact for merge.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msa_managingpartnerid_value|msa_managingpartnerid<br />|Unique identifier for Account associated with Contact.|
|_msdyncrm_campaignid_value|msdyncrm_campaignid<br />||
|_msdyncrm_emailid_value|msdyncrm_emailid<br />||
|_msdyncrm_marketingformid_value|msdyncrm_marketingformid<br />||
|_msdyncrm_marketingpageid_value|msdyncrm_marketingpageid<br />||
|_msevtmgt_contactid_value|msevtmgt_ContactId<br />|Unique identifier for Check-in associated with Contact.|
|_originatingleadid_value|originatingleadid<br />|Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the contact.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the contact.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the contact.|
|_parentcontactid_value||Unique identifier of the parent contact.|
|_parentcustomerid_value|parentcustomerid_account<br />parentcustomerid_contact<br />|Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.|
|_preferredequipmentid_value|preferredequipmentid<br />|Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.|
|_preferredserviceid_value|preferredserviceid<br />|Choose the contact's preferred service to make sure services are scheduled correctly for the customer.|
|_preferredsystemuserid_value|preferredsystemuserid<br />|Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.|
|_slaid_value|sla_contact_sla<br />|Choose the service level agreement (SLA) that you want to apply to the Contact record.|
|_slainvokedid_value|slainvokedid_contact_sla<br />|Last SLA that was applied to this case. This field is for internal use only.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_preferredlanguageid|[adx_portallanguage EntityType](adx_portallanguage.md)|adx_portallanguage_contact|
|createdby|[systemuser EntityType](systemuser.md)|lk_contactbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_contact_createdonbehalfby|
|defaultpricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_contacts|
|masterid|[contact EntityType](contact.md)|contact_master_contact|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_contactbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_contact_modifiedonbehalfby|
|msa_managingpartnerid|[account EntityType](account.md)|msa_contact_managingpartner|
|msdyncrm_campaignid|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_msdyncrm_customerjourney_contact_campaignid|
|msdyncrm_emailid|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_msdyncrm_marketingemail_contact_emailid|
|msdyncrm_marketingformid|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_msdyncrm_marketingform_contact_marketingformid|
|msdyncrm_marketingpageid|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_msdyncrm_marketingpage_contact_marketingpageid|
|msevtmgt_ContactId|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_checkin_contact|
|originatingleadid|[lead EntityType](lead.md)|contact_originating_lead|
|ownerid|[principal EntityType](principal.md)|owner_contacts|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_contacts|
|owningteam|[team EntityType](team.md)|team_contacts|
|owninguser|[systemuser EntityType](systemuser.md)|contact_owning_user|
|parentcustomerid_account|[account EntityType](account.md)|contact_customer_accounts|
|parentcustomerid_contact|[contact EntityType](contact.md)|contact_customer_contacts|
|preferredequipmentid|[equipment EntityType](equipment.md)|equipment_contacts|
|preferredserviceid|[service EntityType](service.md)|service_contacts|
|preferredsystemuserid|[systemuser EntityType](systemuser.md)|system_user_contacts|
|sla_contact_sla|[sla EntityType](sla.md)|manualsla_contact|
|slainvokedid_contact_sla|[sla EntityType](sla.md)|sla_contact|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_contact|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_contact|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|account_primary_contact|[account EntityType](account.md)|primarycontactid|  
|adx_changedcontact_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|adx_changedbyid|  
|adx_contact_externalidentity|[adx_externalidentity EntityType](adx_externalidentity.md)|adx_contactid|  
|adx_contact_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_Recipient|  
|adx_contact_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|adx_contactid|  
|adx_contact_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_contactid|  
|adx_contact_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_authorid|  
|adx_contact_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_contactid|  
|adx_invitation_invitecontact|[adx_invitation EntityType](adx_invitation.md)|adx_inviteContact|  
|adx_invitation_invitecontacts|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_invitecontacts|  
|adx_invitation_invitercontact|[adx_invitation EntityType](adx_invitation.md)|adx_invitercontact|  
|adx_invitation_redeemedContact|[adx_invitation EntityType](adx_invitation.md)|adx_redeemedContact|  
|adx_invitation_redeemedcontacts|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_redeemedcontacts|  
|adx_subscribercontact_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|adx_subscriberid|  
|adx_webformsession_contact|[adx_webformsession EntityType](adx_webformsession.md)|adx_contact|  
|adx_webrole_contact|[adx_webrole EntityType](adx_webrole.md)|adx_webrole_contact|  
|contact_actioncard|[actioncard EntityType](actioncard.md)|regardingobjectid_contact_actioncard|  
|contact_activity_parties|[activityparty EntityType](activityparty.md)|partyid_contact|  
|Contact_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_contact|  
|contact_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_contact_adx_alertsubscription|  
|contact_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_contact_adx_inviteredemption|  
|contact_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_contact_adx_portalcomment|  
|Contact_Annotation|[annotation EntityType](annotation.md)|objectid_contact|  
|Contact_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_contact_appointment|  
|contact_as_primary_contact|[incident EntityType](incident.md)|primarycontactid|  
|contact_as_responsible_contact|[incident EntityType](incident.md)|responsiblecontactid|  
|Contact_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_contact|  
|contact_bookableresource_ContactId|[bookableresource EntityType](bookableresource.md)|ContactId|  
|Contact_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_contact|  
|contact_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_contact_bulkoperation|  
|contact_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_contact_campaignresponse|  
|contact_connections1|[connection EntityType](connection.md)|record1id_contact|  
|contact_connections2|[connection EntityType](connection.md)|record2id_contact|  
|contact_customer_contacts|[contact EntityType](contact.md)|parentcustomerid_contact|  
|Contact_CustomerAddress|[customeraddress EntityType](customeraddress.md)|parentid_contact|  
|Contact_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_contact|  
|Contact_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_contact|  
|Contact_Email_EmailSender|[email EntityType](email.md)|emailsender_contact|  
|Contact_Emails|[email EntityType](email.md)|regardingobjectid_contact_email|  
|contact_entitlement_ContactId|[entitlement EntityType](entitlement.md)|contactid|  
|contact_entitlement_Customer|[entitlement EntityType](entitlement.md)|customerid_contact|  
|Contact_Faxes|[fax EntityType](fax.md)|regardingobjectid_contact_fax|  
|Contact_Feedback|[feedback EntityType](feedback.md)|ContactId|  
|Contact_Letters|[letter EntityType](letter.md)|regardingobjectid_contact_letter|  
|contact_master_contact|[contact EntityType](contact.md)|masterid|  
|contact_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_contact_msdyn_approval|  
|contact_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_contact_msdyn_bookingalert|  
|contact_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_contact_msdyn_surveyinvite|  
|Contact_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_contact_phonecall|  
|contact_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_contact|  
|contact_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_contact|  
|Contact_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_contact_recurringappointmentmaster|  
|Contact_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_contact_serviceappointment|  
|Contact_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_contact_socialactivity|  
|Contact_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_contact_syncerror|  
|Contact_Tasks|[task EntityType](task.md)|regardingobjectid_contact_task|  
|contactinvoices_association|[invoice EntityType](invoice.md)|contactinvoices_association|  
|contactleads_association|[lead EntityType](lead.md)|contactleads_association|  
|contactorders_association|[salesorder EntityType](salesorder.md)|contactorders_association|  
|contactquotes_association|[quote EntityType](quote.md)|contactquotes_association|  
|contract_billingcustomer_contacts|[contract EntityType](contract.md)|billingcustomerid_contact|  
|contract_customer_contacts|[contract EntityType](contract.md)|customerid_contact|  
|contractlineitem_customer_contacts|[contractdetail EntityType](contractdetail.md)|customerid_contact|  
|CreatedContact_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|createdobjectid_contact|  
|entitlementcontacts_association|[entitlement EntityType](entitlement.md)|entitlementcontacts_association|  
|incident_customer_contacts|[incident EntityType](incident.md)|customerid_contact|  
|invoice_customer_contacts|[invoice EntityType](invoice.md)|customerid_contact|  
|lead_customer_contacts|[lead EntityType](lead.md)|customerid_contact|  
|lead_parent_contact|[lead EntityType](lead.md)|parentcontactid|  
|listcontact_association|[list EntityType](list.md)|listcontact_association|  
|lk_contact_feedback_createdby|[feedback EntityType](feedback.md)|CreatedByContact|  
|lk_contact_feedback_createdonbehalfby|[feedback EntityType](feedback.md)|CreatedOnBehalfByContact|  
|msa_contact_incident|[incident EntityType](incident.md)|msa_partnercontactid|  
|msa_contact_opportunity|[opportunity EntityType](opportunity.md)|msa_partneroppid|  
|msdyn_contact_msdyn_actual_ContactCustomer|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_actual_ContactVendor|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_contactpricelist_Contact|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_Contact|  
|msdyn_contact_msdyn_estimateline_ContactCustomer|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_estimateline_ContactVendor|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_fact_ContactCustomer|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_fact_ContactVendor|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_invoicelinetransaction_ContactCustomer|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_invoicelinetransaction_ContactVendor|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_journalline_ContactCustomer|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_journalline_ContactVendor|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_opportunitylinetransaction_ContactCustomer|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_opportunitylinetransaction_ContactVendor|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_orderlinetransaction_ContactCustomer|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_orderlinetransaction_ContactVendor|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_quotelinetransaction_ContactCustomer|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_ContactCustomer|  
|msdyn_contact_msdyn_quotelinetransaction_ContactVendor|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_ContactVendor|  
|msdyn_contact_msdyn_responseoutcome_Contact|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_Contact|  
|msdyn_contact_msdyn_rma_RequestedByContact|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_requestedbycontact|  
|msdyn_contact_msdyn_rtv_VendorContact|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_vendorcontact|  
|msdyn_contact_msdyn_surveyinvite_ContactId|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_ContactId|  
|msdyn_contact_msdyn_surveyresponse_Contact|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_Contact|  
|msdyn_contact_msdyn_workorder_ReportedByContact|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_reportedbycontact|  
|msdyncrm_contact_msdyncrm_campaigncustomchannelactivity_Contact|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|msdyncrm_Contact|  
|msdyncrm_contact_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_ContactGeoPinsId|  
|msdyncrm_contact_msdyncrm_marketingconfiguration_DefaultContact|[msdyncrm_marketingconfiguration EntityType](msdyncrm_marketingconfiguration.md)|msdyncrm_DefaultContact|  
|msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_testcontactid|  
|msevtmgt_contact_msevtmgt_building_PrimaryContact|[msevtmgt_building EntityType](msevtmgt_building.md)|msevtmgt_PrimaryContact|  
|msevtmgt_contact_msevtmgt_checkin_Contact|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|msevtmgt_Contact|  
|msevtmgt_contact_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|msevtmgt_PurchasingContactId|  
|msevtmgt_contact_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|msevtmgt_AttendeeContactId|  
|msevtmgt_contact_msevtmgt_eventregistration_Contact|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|msevtmgt_ContactId|  
|msevtmgt_contact_msevtmgt_eventteammember_Contact|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|msevtmgt_Contact|  
|msevtmgt_contact_msevtmgt_hotel_PrimaryContact|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|msevtmgt_PrimaryContact|  
|msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|msevtmgt_PrimaryContact|  
|msevtmgt_contact_msevtmgt_room_PrimaryContact|[msevtmgt_room EntityType](msevtmgt_room.md)|msevtmgt_PrimaryContact|  
|msevtmgt_contact_msevtmgt_sessionregistration_contactid|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|msevtmgt_contactid|  
|msevtmgt_contact_msevtmgt_speaker_Contact|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|msevtmgt_Contact|  
|msevtmgt_contact_msevtmgt_venue_PrimaryContact|[msevtmgt_venue EntityType](msevtmgt_venue.md)|msevtmgt_PrimaryContact|  
|opportunity_customer_contacts|[opportunity EntityType](opportunity.md)|customerid_contact|  
|opportunity_parent_contact|[opportunity EntityType](opportunity.md)|parentcontactid|  
|order_customer_contacts|[salesorder EntityType](salesorder.md)|customerid_contact|  
|quote_customer_contacts|[quote EntityType](quote.md)|customerid_contact|  
|servicecontractcontacts_association|[contract EntityType](contract.md)|servicecontractcontacts_association|  
|slakpiinstance_contact|[slakpiinstance EntityType](slakpiinstance.md)|regarding_contact|  
|socialactivity_postauthor_contacts|[socialactivity EntityType](socialactivity.md)|postauthor_contact|  
|socialactivity_postauthoraccount_contacts|[socialactivity EntityType](socialactivity.md)|postauthoraccount_contact|  
|Socialprofile_customer_contacts|[socialprofile EntityType](socialprofile.md)|customerid_contact|  
|SourceContact_BulkOperationLogs|[bulkoperationlog EntityType](bulkoperationlog.md)|regardingobjectid_contact|  

## Operations
The following operations can be used with the contact entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[adx_SendEmailConfirmationToContact Action](../actions/adx_sendemailconfirmationtocontact.md)|Entity|[!INCLUDE[../actions/descriptions/adx_sendemailconfirmationtocontact.md](../actions/descriptions/adx_sendemailconfirmationtocontact.md)]|  
|[adx_SendEmailTwoFactorCodeToContact Action](../actions/adx_sendemailtwofactorcodetocontact.md)|Entity|[!INCLUDE[../actions/descriptions/adx_sendemailtwofactorcodetocontact.md](../actions/descriptions/adx_sendemailtwofactorcodetocontact.md)]|  
|[adx_SendPasswordResetToContact Action](../actions/adx_sendpasswordresettocontact.md)|Entity|[!INCLUDE[../actions/descriptions/adx_sendpasswordresettocontact.md](../actions/descriptions/adx_sendpasswordresettocontact.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[Merge Action](../actions/merge.md)|Not Bound|[!INCLUDE[../actions/descriptions/merge.md](../actions/descriptions/merge.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the contact entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Identity Solution](../solutions/microsoftidentity.md)|[!INCLUDE[../solutions/descriptions/microsoftidentity.md](../solutions/descriptions/microsoftidentity.md)]|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|  
|[Event Portal Base Solution](../solutions/eventportallink.md)|[!INCLUDE[../solutions/descriptions/eventportallink.md](../solutions/descriptions/eventportallink.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/contact.md](./remarks/contact.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />