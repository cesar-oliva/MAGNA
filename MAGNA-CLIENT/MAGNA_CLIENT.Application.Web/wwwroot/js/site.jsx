class CommentBox extends React.Component {
    render() {
        return (
            <div className="commentBox">
             <h1 class="display-4">Welcome</h1>
                <CommentList />
                <CommentForm />
            </div>
        );
    }
}
class CommentList extends React.Component {
    render() {
        return (
            <div className="commentList">
                <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
                <Comment author="Cesar Oliva">
                    Hello ReactJS.NET World!
                </Comment>
            </div>
        );
    }
}

class CommentForm extends React.Component {
    render() {
        return (
            <div className="commentForm">Hello, world! I am a CommentForm.</div>
        );
    }
}

class Comment extends React.Component {
    render() {
        const md = createRemarkable();
        return (
            <div className="comment">
                <h2 className="commentAuthor">{this.props.author}</h2>
                {md.render(this.props.children.toString())}
            </div>
        );
    }
}
function createRemarkable() {
    var remarkable =
        'undefined' != typeof global && global.Remarkable
            ? global.Remarkable
            : window.Remarkable;

    return new remarkable();
}

ReactDOM.render(<CommentBox />, document.getElementById('content'));



