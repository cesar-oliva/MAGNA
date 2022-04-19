class CommentBox extends React.Component {
    render() {
        return (
            <div className="commentBox"><NoticeForm/></div>
        );
    }
}

class NoticeForm extends React.Component {
    render() {
        return (
            <form method="post" asp-action="Create">
                <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                <div class="row gx-3 mb-3">
                    <div class="col-md-6">
                        <label asp-for="Id" class="control-label">Id</label>
                        <input asp-for="Id" type="text" class="form-control" readonly />
                        <span asp-validation-for="Id" class="text-danger"></span>
                    </div>
                    <div class="col-md-6">
                        <label asp-for="AssembleCode" class="control-label">Code</label>
                        <input asp-for="AssembleCode" class="form-control" />
                        <span asp-validation-for="AssembleCode" class="text-danger"></span>
                    </div>
                </div>
                <div class="row gx-3 mb-3">
                    <div class="col-md-6">
                        <label asp-for="AssembleDescription" class="control-label">Description</label>
                        <input asp-for="AssembleDescription" class="form-control" />
                        <span asp-validation-for="AssembleDescription" class="text-danger"></span>
                    </div>
                </div>
                <div class="form-group">
                    <input type="submit" value="Create Notice" class="btn-group-lg btn-primary" />
                </div>

            </form>
        );
    }
}

ReactDOM.render(<CommentBox />, document.getElementById('content'));

