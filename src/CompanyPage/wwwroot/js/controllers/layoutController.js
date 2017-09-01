
$(document).on('click', function () {
    $('.navbar-collapse').collapse('hide');
})

function set_body_height() { // set body height = window height
    $('#headercont').height($(window).height());
}
$(document).ready(function () {
    $(window).bind('resize', set_body_height);
    set_body_height();
});

$('.expandable-button').click(function () {
    $(this).siblings().find('.expandable-zone').slideUp(300);
    $(this).find('.expandable-zone').slideToggle(300);
});