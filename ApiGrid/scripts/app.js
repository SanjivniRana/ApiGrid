
$(function () {
    $("#jqGrid").jqGrid({
        url: "http://localhost:61296/api/student",
        datatype: 'json',
        mtype: 'Get',
        colNames: ['Student Name', 'Roll No.', 'Course', 'Department', 'Email', 'Phone No.', 'Address', 'Fathers Name'],
        colModel: [
            { key: true, name: 'Student Name', index: 'Student Name', editable: true },
            { key: false, name: 'Roll No.', index: 'Roll No.', editable: true },
            { key: false, name: 'Course', index: 'Course', editable: true },
            { key: false, name: 'Department', index: 'Department', editable: true },          
            { key: false, name: 'Phone No.', index: 'Phone No.', editable: true },
            { key: false, name: 'Address', index: 'Address', editable: true },
            { key: false, name: 'Fathers Name', index: 'Fathers Name', editable: true },
            { key: false, name: 'Mothers Name', index: 'Mothers Name', editable: true }],
        pager: jQuery('#jqControls'),
        rowNum: 10,
        rowList: [10, 20, 30, 40, 50],
        height: '100%',
        viewrecords: true,
        caption: 'Student Records',
        emptyrecords: 'No Student Records are Available to Display',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            Id: "0"
        },
        autowidth: true,
        multiselect: false
    }).navGrid('#jqControls', { edit: true, add: true, del: true, search: false, refresh: true },
        {
            zIndex: 100,
            url: '/Home/Edit',
            closeOnEscape: true,
            closeAfterEdit: true,
            recreateForm: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/Home/Create",
            closeOnEscape: true,
            closeAfterAdd: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/Home/Delete",
            closeOnEscape: true,
            closeAfterDelete: true,
            recreateForm: true,
            msg: "Are you sure you want to delete Student... ? ",
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        });
});


/*function GetEmployeeInformation() {  
    var url = "http://localhost:4000/api/Home/GetEmployeeInformation?JSONString=" + stringReqdata;  
    jQuery.ajax({  
        dataType: "json",  
        url: url,  
        async: false,  
        context: document.body  
    }).success(function (data) {  
        alert(data);  
    });  
};  
/*************************************GET*****************************************/  
/*function PostSubmitdata() {  
    var url = "http://localhost:4000/api/Home/PostSubmitdata";  
    jQuery.ajax({  
        async: false,  
        type: "POST",  
        url: url,  
        data: stringReqdata,  
        dataType: "json",  
        context: document.body,  
        contentType: 'application/json; charset=utf-8'  
    }).success(function (data) {  
        alert(data);  
    })  
}  

<body>  
<a href="#" onclick="GetEmployeeInformation();">Get</a><br />  
<a href="#" onclick="PostSubmitdata();">Post</a>  
</body>  */