$(document).ready(function () {
    $("#tblData").DataTable({
        "processing": true, // for show progress bar    
        "serverSide": true, // for process server side    
        "filter": true, // this is for disable filter (search box)    
        "orderMulti": false, // for disable multiple column at once    
        "ajax": {
            "url": "/Clients/GetAll",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{
            "targets": [0],
            "visible": false,
            "searchable": false
        }],
        "columns": [
            { "data": "ClientId"},
            { "data": "Civilite", "name": "Civilite", "autoWidth": true },
            { "data": "Nom", "name": "Nom", "autoWidth": true },
            { "data": "Prenom", "name": "Prenom", "autoWidth": true },
            { "data": "Mail", "name": "Mail", "autoWidth": true },
            { "data": "Telephone", "name": "Telephone", "autoWidth": true }
        ]
    });
});


function DeleteData(Id) {
    if (confirm("Are you sure you want to delete ...?")) {
        Delete(Id);
    } else {
        return false;
    }
}


function Delete(Id) {
    var url = '@Url.Content("~/")' + "Clients/Delete";

    $.post(url, { ID: Id }, function (data) {
        if (data) {
            oTable = $('#tblData').DataTable();
            oTable.draw();
        } else {
            alert("Something Went Wrong!");
        }
    });
}  
  