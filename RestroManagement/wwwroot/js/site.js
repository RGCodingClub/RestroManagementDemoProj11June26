// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {
    // Sidebar toggle for admin/restaurant panels
    $(document).on('click', '#sidebar-toggle', function () {
        $('#sidebar').toggleClass('show');
        if ($('#sidebar').hasClass('show')) {
            // Append backdrop if it doesn't exist
            if ($('.sidebar-backdrop').length === 0) {
                $('body').append('<div class="sidebar-backdrop"></div>');
            }
        } else {
            $('.sidebar-backdrop').remove();
        }
    });

    // Close sidebar when clicking backdrop
    $(document).on('click', '.sidebar-backdrop', function () {
        $('#sidebar').removeClass('show');
        $(this).remove();
    });

    // Close sidebar on window resize if size is larger than mobile breakpoint
    $(window).on('resize', function () {
        if ($(window).width() >= 768) {
            $('#sidebar').removeClass('show');
            $('.sidebar-backdrop').remove();
        }
    });
});
