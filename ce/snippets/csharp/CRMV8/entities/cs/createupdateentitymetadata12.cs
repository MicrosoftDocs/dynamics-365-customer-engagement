// <snippetcreateupdateentitymetadata12>


 /// <summary>
 /// Updates the formXml to add a new tab containing the fields added by this sample.
 /// <param name="entityLogicalName">The logical name of the new_bankaccount entity used in this sample</param>
 /// </summary>
 public void UpdateEntityForm(String entityLogicalName)
 {

  QueryExpression qe = new QueryExpression("systemform");
  qe.Criteria.AddCondition("type", ConditionOperator.Equal, 2); //main form
  qe.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, entityLogicalName); //for new_bankaccount entity
  qe.ColumnSet.AddColumn("formxml");
  //Retrieve the first main entity form for this entity
  SystemForm bankAccountMainForm = (SystemForm)_serviceProxy.RetrieveMultiple(qe).Entities[0];

  XDocument bankAccountFormXml = XDocument.Parse(bankAccountMainForm.FormXml);
  //Set the showImage attribute so the entity image will be displayed
  bankAccountFormXml.Root.SetAttributeValue("showImage", true);

  // Definition of a custom tab containing the custom attributes created in this sample
  String formTabXmlString = @"<tab name=""custom_attributes""
      id=""{824792c4-ea85-1504-40e2-b780b26dc6ab}""
      IsUserDefined=""0""
      locklevel=""0""
      showlabel=""true""
      expanded=""true"">
  <labels>
   <label description=""Custom Attributes""
          languagecode=""1033"" />
  </labels>
  <columns>
   <column width=""100%"">
    <sections>
     <section name=""custom_section""
              showlabel=""false""
              showbar=""false""
              locklevel=""0""
              id=""{9bda81ec-e41b-7a4d-08b4-4536c5862ce1}""
              IsUserDefined=""0""
              layout=""varwidth""
              columns=""1""
              labelwidth=""115""
              celllabelalignment=""Left""
              celllabelposition=""Left"">
      <labels>
       <label description=""Section""
              languagecode=""1033"" />
      </labels>
      <rows>
       <row>
        <cell id=""{04b95931-78c7-6913-a005-922d20e521b7}""
              showlabel=""true""
              locklevel=""0"">
         <labels>
          <label description=""Account Owner""
                 languagecode=""1033"" />
         </labels>
         <control id=""new_parent_contactid""
                  classid=""{270BD3DB-D9AF-4782-9025-509E298DEC0A}""
                  datafieldname=""new_parent_contactid""
                  disabled=""false"" />
        </cell>
       </row>
       <row>
        <cell id=""{6e5975d3-64b5-14eb-00e4-064e3dd298b9}""
              showlabel=""true""
              locklevel=""0"">
         <labels>
          <label description=""Bank Name""
                 languagecode=""1033"" />
         </labels>
         <control id=""new_bankname""
                  classid=""{4273EDBD-AC1D-40d3-9FB2-095C621B552D}""
                  datafieldname=""new_bankname""
                  disabled=""false"" />
        </cell>
       </row>
       <row>
        <cell id=""{3b436dba-6156-42e9-697b-e275d373505b}""
              showlabel=""true""
              locklevel=""0"">
         <labels>
          <label description=""Balance""
                 languagecode=""1033"" />
         </labels>
         <control id=""new_balance""
                  classid=""{533B9E00-756B-4312-95A0-DC888637AC78}""
                  datafieldname=""new_balance""
                  disabled=""false"" />
        </cell>
       </row>
       <row>
        <cell id=""{0e9a3d8a-bd69-71ad-4ca4-2dcd10858719}""
              showlabel=""true""
              locklevel=""0"">
         <labels>
          <label description=""Date""
                 languagecode=""1033"" />
         </labels>
         <control id=""new_checkeddate""
                  classid=""{5B773807-9FB2-42db-97C3-7A91EFF8ADFF}""
                  datafieldname=""new_checkeddate""
                  disabled=""false"" />
        </cell>
       </row>
      </rows>
     </section>
    </sections>
   </column>
  </columns>
 </tab>";

  XDocument formTabXml = XDocument.Parse(formTabXmlString);

  //Adding this tab to the tabs element
  bankAccountFormXml.Root.Element("tabs").Add(formTabXml.Root);
  //Updateing the entity form definition
  bankAccountMainForm.FormXml = bankAccountFormXml.ToString();
  //saving the bank account form
  _serviceProxy.Update(bankAccountMainForm);

 }

// </snippetcreateupdateentitymetadata12>