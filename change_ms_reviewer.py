import os

def update_markdown_metadata(directories):
    """
    Update Markdown files' metadata in the specified directories.

    Args:
        directories (list of str): List of directories to process.
    """
    for directory in directories:
        for root, _, files in os.walk(directory):
            for file in files:
                if file.endswith(".md"):
                    file_path = os.path.join(root, file)
                    update_file_metadata(file_path)

def update_file_metadata(file_path):
    """
    Update metadata in a Markdown file.

    Args:
        file_path (str): Path to the Markdown file.
    """
    with open(file_path, 'r', encoding='utf-8') as file:
        lines = file.readlines()

    # Find metadata block and relevant fields
    metadata_start, metadata_end = find_metadata_block(lines)
    if metadata_start is None or metadata_end is None:
        return  # No metadata block found

    metadata_lines = lines[metadata_start:metadata_end + 1]
    ms_author_value = None
    ms_author_index = None
    ms_reviewer_index = None

    for i, line in enumerate(metadata_lines):
        if line.startswith('ms.author:'):
            ms_author_value = line.split(':', 1)[1].strip()
            ms_author_index = i
        elif line.startswith('ms.reviewer:'):
            ms_reviewer_index = i

    if ms_author_value:
        if ms_reviewer_index is not None:
            # Update existing ms.reviewer field
            metadata_lines[ms_reviewer_index] = f'ms.reviewer: {ms_author_value}\n'
        elif ms_author_index is not None:
            # Add ms.reviewer field below ms.author
            metadata_lines.insert(ms_author_index + 1, f'ms.reviewer: {ms_author_value}\n')

        # Write updated lines back to the file
        lines[metadata_start:metadata_end + 1] = metadata_lines
        with open(file_path, 'w', encoding='utf-8') as file:
            file.writelines(lines)

def find_metadata_block(lines):
    """
    Find the start and end indices of the metadata block in a Markdown file.

    Args:
        lines (list of str): Lines of the file.

    Returns:
        tuple: (start_index, end_index) of metadata block, or (None, None) if not found.
    """
    start, end = None, None
    for i, line in enumerate(lines):
        if line.strip() == "---" and start is None:
            start = i
        elif line.strip() == "---" and start is not None:
            end = i
            break
    return start, end

# Run script with the specified list of directories
if __name__ == "__main__":
    directories = [
        "./ce/customer-service",
        "./ce/customer-service/administrator",
        "./ce/customer-service/develop",
        "./ce/customer-service/implement",
        "./ce/customer-service/use",
        "./ce/channel-integration-framework",
        "./ce/unified-service-desk"
    ]
    update_markdown_metadata(directories)
