$(document).ready(function () {

    //if (!!$.cookie('activesidebar')) {

    //} else {
    //    var t = $(this).hasClass('active');
    //    $.cookie('activesidebar', t);
    //}

    //function checkSideState() {
    //    var co = $.cookie('activesidebar');
    //    if ($.cookie('activesidebar')) {
    //        $('#sidebar').addClass('active');
    //        $('#sidebarCollapse').addClass('active');
    //    }
    //}

    //checkSideState();

    $('#sidebarCollapse').on('click', function () {
        $(this).toggleClass('active');
        setTimeout(2000, $('#sidebar').toggleClass('active'));
        $('#sidebar .sidebar-header img').toggleClass('active');
        //$.cookie('activesidebar', $(this).hasClass('active'));
        //console.log($.cookie('activesidebar'));
    });

   

    
    


    $('#date').datepicker({
        showButtonPanel: true,
        dateFormat: "yy/mm/dd"
    });

});