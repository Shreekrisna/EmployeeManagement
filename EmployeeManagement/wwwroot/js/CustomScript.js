function confirmDelete(uniqueId, isDeleteClicked) {
    var DeleteSpan = 'DeleteSpan_' + uniqueId;
    var ConfirmDeleteSpan = 'ConfirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + DeleteSpan).hide();
        $('#' + ConfirmDeleteSpan).show();
    }
    else {
        $('#' + DeleteSpan).show();
        $('#' + ConfirmDeleteSpan).hide();
    }


}
