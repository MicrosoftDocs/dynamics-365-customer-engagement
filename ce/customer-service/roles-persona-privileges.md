---
title: "Roles, persona, and privileges | MicrosoftDocs"
description: "Information about how security roles can be mapped to persona and privileges."
ms.date: 08/31/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Roles, persona, and privileges

This topic lists the roles, persona, and privileges for the agent, supervisor, and administrator.
More information: [Manage personas](role-persona-mapping.md#manage-personas) 

## Role: Administrator

|	Entity name	|	Entity or Metadata	|	Privilege Name	|	Depth	|
|	   -----    |------	                |	------          |	  ---  	|
|	Activity	                          |	Activity	                          |	Append	                                  |	Local	|
|		                                  |		                                  |	AppendTo	                              |	Local	|
|		                                  |		                                  |	Assign	                                  |	Deep	|
|		                                  |		                                  |	Create	                                  |	Basic	|
|		                                  |		                                  |	Delete	                                  |	Local	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Local	|
|	AdminAppState	                      |	msdyn_adminappstate	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Agent Status history	              |	msdyn_agentstatushistory	          |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	AI Configuration	                  |	msdyn_aiconfiguration	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	AI Model	                          |	msdyn_aimodel	                      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	AI Template	                          |	msdyn_aitemplate	                  |	Read	                                  |	Global	|
|	App Module	                          |	AppModule	                          |	Update	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|	App Profile	                          |	msdyn_appconfiguration	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	App Configuration	                  |	AppConfig	                          |	Read	                                  |	Global	|
|	App Parameter Definition (Deprecated) |	msdyn_consoleappparameterdefinition	  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Application Extension	              |	msdyn_applicationextension	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Application Tab Template	          |	msdyn_applicationtabtemplate	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Application Tab Template (Deprecated) |	msdyn_consoleapplicationtemplate      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Application Type (Deprecated)	      |	msdyn_consoleapplicationtype	      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Assignment Configuration	          |	msdyn_assignmentconfiguration	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Assignment Configuration Step	      |	msdyn_assignmentconfigurationstep     |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Audio File	                          |	msdyn_soundfile	                      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Bookable Resource	                  |	BookableResource	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Bookable Resource Capacity Profile	  |	msdyn_bookableresourcecapacityprofile |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Bookable Resource Characteristic	  |	BookableResourceCharacteristic	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Capacity Profile	                  |	msdyn_capacityprofile	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	channel	                              |	msdyn_channel	                      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Channel Provider	                  |	msdyn_channelprovider	              |	Update	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|	Channel Configuration	              |	msdyn_occhannelconfiguration	      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Channel Integration Framework v1.0 Provider	          |	msdyn_ciprovider      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Channel State Configuration	          |	msdyn_occhannelstateconfiguration	  |	Read	                                  |	Global	|
|	Characteristic	                      |	Characteristic	                      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Characteristic mapping	              |	msdyn_ocsitdskill	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Charts	                              |	SavedQueryVisualizations	          |	Read	                                  |	Global	|
|	Columns	                              |	Attribute	                          |	Update	                                  |	Global	|
|	Context item value	                  |	msdyn_ocliveworkitemcontextitem	      |	Append	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Context variable	                  |	msdyn_ocliveworkstreamcontextvariable |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Conversation Capacity profile	      |	msdyn_ocliveworkitemcapacityprofile   |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Conversation Characteristic	          |	msdyn_ocliveworkitemcharacteristic	  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Conversation Sentiment	              |	msdyn_ocliveworkitemsentiment	      |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Custom messaging account	          |	msdyn_ocbotchannelregistration	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Customization	                      |	Customization	                      |	Publish	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Decision contract	                  |	msdyn_decisioncontract	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|	Decision rule set	                  |	msdyn_decisionruleset	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|	Deprecated Workstream Entity Configuration	   |	msdyn_entityconfig	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Entity	                              |	msdyn_entityroutingconfiguration	  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Entity Routing Context	              |	msdyn_cdsentityengagementctx	      |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Forms	                              |	SystemForm	                          |	Read	                                  |	Global	|
|	Geo Location Provider	              |	msdyn_oc_geolocationprovider	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	KPI Event Definition	              |	msdyn_kpieventdefinition	          |	Read	                                  |	Global	|
|	Language	                          |	msdyn_oclanguage	                  |	Read	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Live work item event	              |	msdyn_liveworkitemevent	              |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Live Work Item Participant (Deprecated) |	msdyn_ocliveworkitemparticipant	  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Localization	                      |	msdyn_oclocalizationdata	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Masking Rule	                      |	msdyn_maskingrule	                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Master Entity Routing Configuration	  |	msdyn_masterentityroutingconfiguration	  |	Create	                              |	Local	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Delete	                                  |	Deep	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Local	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Delete	                                  |	Deep	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|	Message	                              |	msdyn_ocsystemmessage	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Model training details	              |	msdyn_ocsimltraining	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Notification Field	                  |	msdyn_notificationfield	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Notification Template	              |	msdyn_notificationtemplate	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Notification Field (Deprecated)	      |	msdyn_consoleapplicationnotificationfield	       |	Read	                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Notification Template (Deprecated)	  |	msdyn_consoleapplicationnotificationtemplate	     |	Read	                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Omnichannel Queue (deprecated)	      |	msdyn_omnichannelqueue	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Omnichannel Configuration	          |	msdyn_omnichannelconfiguration	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Omnichannel Personalization	          |	msdyn_omnichannelpersonalization	  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Ongoing conversation (Deprecated)	  |	msdyn_liveconversation	              |	Append	                                  |	Local	|
|		                                  |		                                  |	AppendTo	                              |	Local	|
|		                                  |		                                  |	Assign	                                  |	Deep	|
|		                                  |		                                  |	Create	                                  |	Basic	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Local	|
|	Operating Hour	                      |	msdyn_operatinghour	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Pane tool configuration	              |	msdyn_panetoolconfiguration           |	Read	                                  |	Global	|
|	Parameter (Deprecated)	              |	msdyn_consoleapplicationtemplateparameter	              |	Read	              |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Persona Security Role Mapping	      |	msdyn_personasecurityrolemapping	  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|	Personal quick reply	              |	msdyn_personalmessage	              |	Append	                                  |	Basic	|
|		                                  |		                                  |	AppendTo	                              |	Basic	|
|		                                  |		                                  |	Create	                                  |	Basic	|
|		                                  |		                                  |	Delete	                                  |	Basic	|
|		                                  |		                                  |	Read	                                  |	Basic	|
|		                                  |		                                  |	Update	                                  |	Basic	|
|	Personal sound setting	              |	msdyn_Personalsoundsetting	          |	Append	                                  |	Basic	|
|		                                  |		                                  |	AppendTo	                              |	Basic	|
|		                                  |		                                  |	Delete	                                  |	Basic	|
|		                                  |		                                  |	Create	                                  |	Basic	|
|		                                  |		                                  |	Read	                                  |	Basic	|
|		                                  |		                                  |	Update	                                  |	Basic	|
|	PluginAssembly	                      |	PluginAssembly	                      |	Read	                                  |	Global	|
|	PluginType	                          |	PluginType	                          |	Read	                                  | Global	|
|	Power BI Configuration	              |	msdyn_analytics	                      |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Presence	                          |	msdyn_presence	                      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Productivity pane configuration	      |	msdyn_paneconfiguration	              |	Read	                                  |	Global	|
|	Provisioning State	                  |	msdyn_ocprovisioningstate	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Publisher	                          |	Publisher	                          |	Read	                                  |	Global	|
|	Publisher Address	                  |	PublisherAddress	                  |	Read	                                  |	Global	|
|	Query	                              |	Query	                              |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Queue	                              |	Queue	                              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Quick reply	                          |	msdyn_cannedmessage	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Rating Model	                      |	RatingModel	                          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Rating Value	                      |	RatingValue	                          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Recording	                          |	msdyn_ocrecording	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Relationship	                      |	Relationship	                      |	Update	                                  |	Global	|
|	Role	                              |	Role	                              |	Read	                                  |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Routing configuration	              |	msdyn_routingconfiguration	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Routing configuration step	          |	msdyn_routingconfigurationstep	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Rule Item	                          |	msdyn_ocruleitem	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Rulesetentitymapping	              |	msdyn_rulesetdependencymapping        |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Scenario	                          |	msdyn_scenario	                      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	SdkMessage	                          |	SdkMessage	                          |	Read	                                  |	Global	|
|	SdkMessageProcessingStep	          |	SdkMessageProcessingStep	          |	Read	                                  |	Global	|
|	SdkMessageProcessingStepImage	      |	SdkMessageProcessingStepImage         |	Read	                                  |	Global	|
|	Search Configuration	              |	msdyn_searchconfiguration	          |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Self service	                      |	msdyn_visitorjourney	              |	Read	                                  |	Global	|
|	Sentiment Analysis	                  |	msdyn_sentimentanalysis	              |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Service Endpoint	                  |	ServiceEndpoint	                      |	Read	                                  |	Global	|
|	Session event	                      |	msdyn_sessionevent	                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Session Template	                  |	msdyn_sessiontemplate	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Session Characteristic	              |	msdyn_ocsessioncharacteristic         |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Session participant	                  |	msdyn_sessionparticipant	          |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Session Templates (Deprecated)	 |	msdyn_consoleapplicationsessiontemplate	  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	SharePoint Data	                      |	SharePointData	                      |	Create	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	SharePointDocument	                  |	SharePointDocument	                  |	Read	                                  |	Global	|
|	Skill finder model	                  |	msdyn_ocskillidentmlmodel	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Solution	                          |	Solution	                          |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Sound notification setting	          |	msdyn_soundnotificationsetting	      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	System User	                          |	User	                              |	Read	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Table	                              |	Entity	                              |	Update	                                  |	Global	|
|	Tag	                                  |	msdyn_octag	                          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Template Parameter	                  |	msdyn_templateparameter	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Template Tag (Deprecated)	          |	msdyn_templatetags	                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|	Training data import configuration	  |	msdyn_ocsitdimportconfig	          |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Training record	                      |	msdyn_ocsitrainingdata	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Transcript	                          |	msdyn_transcript	                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Unified routing diagnostic	          |	msdyn_unifiedroutingdiagnostic	      |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Unified routing run	                  |	msdyn_unifiedroutingrun	              |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|	UR notification template	          |	msdyn_urnotificationtemplate	      |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|	UR Notification Template Mappin       |	msdyn_urnotificationtemplatemapping	  | Read                                      | Global  |
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|	User Setting	                      |	msdyusd_usersettings                  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	User settings	                      |	msdyn_usersettin                      |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Work stream capacity profile	      |	msdyn_liveworkstreamcapacityprofile	  |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Assign	                                  |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|	Workstream	                          | msdyn_liveworkstream	              |	Append	                                  |	Global	|
|		                                  |		                                  |	AppendTo	                              |	Global	|
|		                                  |		                                  |	Create	                                  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Global	|
|		                                  |		                                  |	Read	                                  |	Global	|
|		                                  |		                                  |	Update	                                  |	Global	|
|		                                  |		                                  |	Share	                                  |	Global	|
|                                         |	                             		  | Assign		                              | Global	|
| | | | 


## Role: Supervisor

## Role: Agent

| Entity name	| Entity or Metadata | Privilege name	| Depth or Level    |
|---------------|--------------------|------------------| --------          |
| Solution      | Solution           |   Read           | Global            |



### See also

[Overview of unified routing](overview-unified-routing.md)  
[Manage users for unified routing](users-user-profiles.md)  
[Add custom security roles in Customer Service](role-persona-mapping.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]  