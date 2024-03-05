$(document).ready(function () {
    $('#myTable').DataTable({
        "ajax": {
            "url": "/Admin/Administration/GetAllRole",
        },
        "columns": [
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <select class="form-select action-select">
                            <option value="">Actions</option>
                            <option value="edit">Edit</option>
                            <option value="delete">Delete</option>
                            <option value="control">Control</option>
                        </select>
                    `;
                }
            },
            { "data": "id" },
            { "data": "name" }
        ]
    });

    // Event delegation for handling action selection
    $('#myTable').on('change', '.action-select', function () {
        var action = $(this).val();
        var id = $(this).closest('tr').find('td:eq(1)').text().trim(); // Adjusted selector
        handleAction(action, id);
    });
});

function handleAction(action, id) {
    if (action === "edit") {
        window.location.href = "/Admin/Administration/Edit?id=" + id;
    } else if (action === "delete") {
        window.location.href = "/Admin/Administration/Delete?id=" + id;
    } else {
        window.location.href = "/Admin/Administration/Actions?id=" + id;
    }
}
